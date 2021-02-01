using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K_Eszter_2021._02._01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Másodfokú egyenlet megoldása függvénnyel és eljárással!
            masodfoku();
            Console.WriteLine();
            double szam = fmasodfoku();
            Console.WriteLine("fmasodfoku értéke: ", szam);
            Console.ReadKey();
        }

        //eljárás
        static void masodfoku()
        {
            Console.Write("Kérem adja meg a másodfokú egyenlet \"a,b,c\" változóit: ");
            string szoveg = Console.ReadLine();
            string[] darabol = szoveg.Split(' ');
            int a = int.Parse(darabol[0]);
            int b  =  int.Parse(darabol[1]);
            int c  =  int.Parse(darabol[2]);
            double negyzetgyok = Math.Pow(b, 2) - 4 * a * c;
            if(negyzetgyok < 0)
            {
                Console.WriteLine("Az egyenletnek nincs megoldása!!!");
            }
            else if (negyzetgyok == 0)
            {
                Console.WriteLine($"Az egyenletnek két egybeeső gyöke van: {-b  /  2  *  a}");
            }
            else
            {
                Console.WriteLine($"x1={-b  +  negyzetgyok  /  2  *  a}");
                Console.WriteLine($"x2={-b - negyzetgyok / 2 * a}");
            }
            //Console.ReadKey();
        }

        //függvény
        static double fmasodfoku(int o, int p, int m)
        {
            Console.Write("Kérem adja meg a másodfokú egyenlet \"a,b,c\" változóit: ");
            string szoveg = Console.ReadLine();
            string[] darabol = szoveg.Split(' ');
            int a = int.Parse(darabol[0]);
            int b = int.Parse(darabol[1]);
            int c = int.Parse(darabol[2]);
            double negyzetgyok = Math.Pow(b, 2) - 4 * a * c;
            if (negyzetgyok < 0)
            {
                Console.WriteLine("Az egyenletnek nincs megoldása!!!");
                return 0;
            }
            else if (negyzetgyok == 0)
            {
                Console.WriteLine($"Az egyenletnek két egybeeső gyöke van: {-b / 2 * a}");
                return 0;
            }
            else
            {
                Console.WriteLine($"x1={-b + negyzetgyok / 2 * a}");
                Console.WriteLine($"x2={-b - negyzetgyok / 2 * a}");
                return 0;
            }
        }
    }
}
