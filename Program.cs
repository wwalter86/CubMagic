using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCubMagic
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] x ={
                {1,0,0,1,1,0,0,1},
                {0,1,1,0,0,1,1,0},
                {0,1,1,0,0,1,1,0},
                {1,0,0,1,1,0,0,1},
                {1,0,0,1,1,0,0,1},
                {0,1,1,0,0,1,1,0},
                {0,1,1,0,0,1,1,0},
                {1,0,0,1,1,0,0,1},
        };
            int y = 0;
            int z = 65;
            for (int i = 0; i < 8; i++)
            {

                for (int j = 7; j >= 0; j--)
                {
                    y = y + 1;
                    z = z - 1;
                    if (x[i, j] == 1)
                    {
                        x[i, j] = y;
                    }
                    else
                    {
                        x[i, j] = z;
                    }
                }
            }

            for (int i = 0; i < 8; i++)
            {

                for (int j = 0; j < 8; j++)
                {
                    Console.Write("{0},", x[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.ReadKey();

            for (int i = 0; i < 4; i++)
            {

                for (int j = 0; j < 4; j++)
                {
                    Console.Write("{0},", x[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.ReadKey();


            for (int i = 0; i < 4; i++)
            {

                for (int j = 4; j < 8; j++)
                {
                    Console.Write("{0},", x[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.ReadKey();

            for (int i = 4; i < 8; i++)
            {

                for (int j = 0; j < 4; j++)
                {
                    Console.Write("{0},", x[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.ReadKey();

            for (int i = 4; i < 8; i++)
            {

                for (int j = 4; j < 8; j++)
                {
                    Console.Write("{0},", x[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();





            for (int i = 0; i < 8; i++)
            {

                for (int j = 0; j < 8; j++)
                {
                    Console.Write("{0},", Convert.ToString(x[i, j], 2).PadLeft(7, '0'));
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.ReadKey();

            for (int i = 0; i < 4; i++)
            {

                for (int j = 0; j < 4; j++)
                {
                    Console.Write("{0},", Convert.ToString(x[i, j], 2).PadLeft(7, '0'));
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.ReadKey();


            for (int i = 0; i < 4; i++)
            {

                for (int j = 4; j < 8; j++)
                {
                    Console.Write("{0},", Convert.ToString(x[i, j], 2).PadLeft(7, '0'));
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.ReadKey();

            for (int i = 4; i < 8; i++)
            {

                for (int j = 0; j < 4; j++)
                {
                    Console.Write("{0},", Convert.ToString(x[i, j], 2).PadLeft(7, '0'));
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.ReadKey();

            for (int i = 4; i < 8; i++)
            {

                for (int j = 4; j < 8; j++)
                {
                    Console.Write("{0},", Convert.ToString(x[i, j], 2).PadLeft(7, '0'));
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            Console.ReadKey();
        }
    }
}
