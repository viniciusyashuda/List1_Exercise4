using System;

namespace List1_Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int number, i, div = 0;

            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());

            for (i = 1; i <= number; i++)
            {

                if (number % i == 0)
                {

                    div += 1;

                }

            }
            if (div == 2)
            {

                Console.WriteLine(number + " is a prime number");

            }
            else
            {

                Console.WriteLine(number + " is not a prime number");

            }

            Console.ReadKey();

        }
    }
}
