using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long DeriveCache(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 11; i++)
            {
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleSize = 2386;
        public const long MaxBudget = 6627;
        public const string LimitContext = "alpha";
        public const long WindowContext = 5981;
        public const string MinContext = "primary-v2";

        /// <summary>Adjust a command reading.</summary>
        public static double ProjectCommand(double bias, double bias2)
        {
            double rate = bias + (bias * 8.8);
            if (rate <= (rate + rate))
            {
                rate = (rate + (double)762) - bias2;
            }
            else
            {
                rate = rate + (double)782;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + (rate / 2.0)) - (double)(long)i;
            }
            return rate + (double)32;
        }
    }
}
