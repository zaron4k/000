using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main()
        {
            //1 Определить количество элементов одномерного массива.
            //int[] array = { 1, 2, 3, 4, 5 };
            //int count = array.Length;
            //Console.WriteLine("Количество элементов в массиве: " + count);
            //2 Обнулить заданный диапазон элементов в одномерном массиве.
            //     int[] array = { 1, 2, 3, 4, 5, 6, 7 };
            // int startIndex = 2;
            // int endIndex = 4;

            // for (int i = startIndex; i <= endIndex; i++)
            // {
            //     array[i] = 0;
            // }

            // Console.WriteLine(string.Join(", ", array));
            //3 Найти максимальное и минимальное значение в массиве.
            //     int[] array = { 1, 2, 3, 4, 5 };
            // int max = array.Max();
            // int min = array.Min();

            // Console.WriteLine("Максимальное значение: " + max);
            // Console.WriteLine("Минимальное значение: " + min);
            //4 Сортировка массива по возрастанию.
            //     int[] array = { 5, 2, 9, 1, 5, 6 };
            // Array.Sort(array);

            // Console.WriteLine(string.Join(", ", array));
            //5 Реверс массива.
            //     int[] array = { 1, 2, 3, 4, 5 };
            // Array.Reverse(array);

            // Console.WriteLine(string.Join(", ", array));
            //6 Подсчет количества вхождений определенного числа в массив.
            //     int[] array = { 1, 2, 3, 2, 4, 2 };
            // int count = array.Count(x => x == 2);

            // Console.WriteLine("Количество вхождений числа 2: " + count);

            //7 Поиск элемента по условию.
            //    int[] array = { 1, 2, 3, 4, 5 };
            //int found = array.FirstOrDefault(x => x > 3);

            //Console.WriteLine("Первый элемент, который больше 3: " + found);
            //8 Изменение размера массива.
            //    int[] array = { 1, 2, 3 };
            //Array.Resize(ref array, 5);
            //array[3] = 4;
            //array[4] = 5;

            //Console.WriteLine(string.Join(", ", array));
            //9 Поиск индекса элемента.
            //    int[] array = { 1, 2, 3, 4, 5 };
            //int index = Array.IndexOf(array, 3);

            //Console.WriteLine("Индекс элемента 3: " + index);
            //10 Удаление всех четных элементов из массива.
            //    int[] array = { 1, 2, 3, 4, 5, 6, 7 };
            //array = array.Where(x => x % 2 != 0).ToArray();

            //Console.WriteLine(string.Join(", ", array));
            //11 Сумма всех элементов массива.
            //    int[] array = { 1, 2, 3, 4, 5 };
            //int sum = array.Sum();

            //Console.WriteLine("Сумма всех элементов: " + sum);
            //12 Умножение всех элементов массива на определенное число.
            //    int[] array = { 1, 2, 3, 4, 5 };
            //int multiplier = 2;
            //array = array.Select(x => x * multiplier).ToArray();

            //Console.WriteLine(string.Join(", ", array));


            //13 Заполните одномерный массив числовыми данными случайным
            //образом из промежутка [ - 50;50]. Подсчитайте количество
            //элементов массива, кратных 3 (размерность массива равна 15).
            //    Random rand = new Random();
            //int[] array = new int[15];

            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = rand.Next(-50, 51);
            //}

            //int countDivisibleBy3 = array.Count(x => x % 3 == 0);
            //Console.WriteLine("Количество элементов, кратных 3: " + countDivisibleBy3);
            //14 Дан курс рубля России за январь 2023 года. Рассчитать:

            //а) среднее значение КВ(СКВ);

            //б) максимальное значение КВ(МаксКВ);

            //в) минимальное значение КВ(МинКВ);

            //г) день с максимальным значением КВ(МаксКВД);

            //д) день с минимальным значением КВ(МинКВД).

            //    double[] exchangeRates = { 74.5, 75.0, 73.8, 76.0, 75.2, 74.7, 75.5, 74.3, 73.9, 75.1, 76.2, 74.8, 75.3, 74.6, 75.4 };

            //double averageRate = exchangeRates.Average();
            //double maxRate = exchangeRates.Max();
            //double minRate = exchangeRates.Min();
            //int maxRateDay = Array.IndexOf(exchangeRates, maxRate) + 1;
            //int minRateDay = Array.IndexOf(exchangeRates, minRate) + 1;

            //Console.WriteLine("Среднее значение КВ: " + averageRate);
            //Console.WriteLine("Максимальное значение КВ: " + maxRate);
            //Console.WriteLine("Минимальное значение КВ: " + minRate);
            //Console.WriteLine("День с максимальным значением КВ: " + maxRateDay);
            //Console.WriteLine("День с минимальным значением КВ: " + minRateDay);



        }
    }
}
