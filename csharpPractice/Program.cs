using System;

namespace csharpPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task-1

            //1. Daxil edilmiş string dəyərinin içində rəqəm olub olmadığını tapan proqram

            //Console.WriteLine("Deyer daxil edin: ");
            //var isString = Console.ReadLine();

            //for (int i = 0; i < isString.Length; i++)
            //{
            //    if (Convert.ToInt32(isString[i]) >=48 && Convert.ToInt32(isString[i])<=57)
            //    {
            //        Console.WriteLine("Vardir");
            //        break;
            //    }
            //}
            #endregion

            #region Task-2
            //2. Daxil edilmiş string  dəyərində  ardıcıl a ve l char-larının olub olmadığını tapan proqram.Misalçün alma, salam və s. kimi sözlərdə "vardir" yazdırmalıdır geriyə.
            //Console.WriteLine("Deyer daxil edin: ");
            //var str = Console.ReadLine();
            //for (int i = 0; i < str.Length; i++)
            //{
            //    if (str[i] == 'a' || str[i] == 'A')
            //    {
            //        if (str[i+1] == 'l')
            //        {
            //            Console.WriteLine("ardicil a ve l charlari vardir");
            //        }
            //    }
            //    else if (str[i] =='l' || str[i] == 'L')
            //    {
            //        if (str[i+1] == 'a')
            //        {
            //            Console.WriteLine("ardicil l ve a charlari vardir");
            //        }
            //    }

            //}
            #endregion

            #region Task-3
            //3. Verilmiş ədədin rəqəmlərinin ədədi ortasını tapan proqram
            //Console.WriteLine("Eded daxil edin: ");
            //var number = Convert.ToInt32(Console.ReadLine());
            //int digit = 0, sum = 0, count = 0, avg;
            //while (0 < number)
            //{
            //    digit = number % 10;
            //    sum += digit;
            //    number /= 10;
            //    count++;
            //}
            //avg = sum / count;
            //Console.WriteLine("Verilmis edein reqemlerinin ededi ortasi: "+ avg);
            #endregion

            #region Task-4
            //4. Daxil edilmiş yazı siyahısında (string array) neçə sözdə rəqəm olduğunu tapan proqram
            //Console.WriteLine("Yazi sayini daxil et: ");
            //string strCounter = Console.ReadLine();

            //int strCount = Convert.ToInt32(strCounter);

            //string[] str = new string[strCount];
            //int count = 0;
            //for (int i = 0; i < strCount; i++)
            //{
            //    Console.WriteLine($"{i + 1}. yazini daxil et");
            //    str[i] = Console.ReadLine();
            //}

            //for (int i = 0; i < str.Length; i++)
            //{
            //    for (int j = 0; j < str[i].Length; j++)
            //    {
            //        if (Convert.ToInt32(str[i][j]) >= 48 && Convert.ToInt32(str[i][j]) <= 57)
            //        {
            //            count++;
            //            break;
            //        }
            //    }
            //}
            //Console.WriteLine("Icerisinde reqem olan sozlerin sayi: "+count);

            #endregion
        }
    }
}
