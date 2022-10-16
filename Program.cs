using System;

namespace MutlakKare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen Satı giriniz: ");
            string number  = Console.ReadLine();
            Calculate(number);

        }

        public static void Calculate(string value)
        {
            string[] numbers = value.Split(" ");
            int number;
            int smallSum = 0;
            int bigSum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                number = Convert.ToInt32(numbers[i]);

                if(number <= 67)
                {
                    smallSum += (67 - number);
                }
                else
                {
                    bigSum += ((number - 67) * (number - 67));
                }
            }
            Console.Write("{0} ",smallSum);
            Console.Write("{0} ",bigSum);

        }
    }
}