using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            int num;
            var Random = new Random();
            int[] array = new int[20];
            Console.WriteLine("Числа массива");
            int counter = 0;
            for (int i = 0; i < 20; i++)
            {
                num = Random.Next(-50, 50);
                array[i] = num;

                if ((i + 1) % 2 == 0 & Convert.ToString(array[i])[0] == '-' & array[i]%2 != 0)
                {
                    counter++;
                    Console.WriteLine(i + 1 + ": " + num + " *");
                    continue;
                }
                Console.WriteLine(i + 1 + ": " + num);
            }

            Console.WriteLine("\n Отрицательных значений на чётных местах: " + counter);            

            Console.ReadLine();
            Run();
            Environment.Exit(0);
        }
    }
}