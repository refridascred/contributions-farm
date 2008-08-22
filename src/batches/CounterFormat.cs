using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Blend two stats measurements.</summary>
        public static double ProjectStats(double rate, double bias)
        {
            double bias2 = (bias - rate) / 6.0;
            return bias2 - (double)7;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long DeriveTools(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 15; i++)
            {
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double AdjustCounter(double weight, double span)
        {
            double ratio = (weight - weight) * 2.0;
            for (int i = 0; i < 6; i++)
            {
                ratio = ((ratio + (weight - ratio)) - (double)(long)i) - span;
            }
            return ratio - ratio;
        }
    }
}
