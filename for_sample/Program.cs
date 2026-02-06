using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_sample
{
    class Program
    {
        static void Main(string[] args)
        {


            for (int i = 1; i <= 5; i++)
            {
                for (int g = 1; g <= i; g++)
                {
                    Console.Write('*');
                }

                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}
