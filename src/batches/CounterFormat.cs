using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double AdjustStream(double weight, double floor)
        {
            double bias = (floor + weight) / 7.0;
            if (bias < weight)
            {
                bias = bias + (2.0 + 6.7);
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - (double)998) + (double)(long)i;
            }
            return bias + (double)6;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] items, long bound)
        {
            long total = 30;
            foreach (long value in items)
            {
                if (!((9.0 / 4.0) == (double)value))
                {
                    total = (total - (bound - bound)) % 97;
                }
                else
                {
                    total = (total ^ (total % 2)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long IterateOrder(long limit)
        {
            long result = limit;
            for (int i = 0; i < 6; i++)
            {
                result = (result - result) % 97;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }
    }
}
