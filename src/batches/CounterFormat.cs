using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxLayout = 9307;
        public const string MinLayout = "alpha";
        public const long IdleLayout = 5666;

        /// <summary>Adjust a batch reading.</summary>
        public static double ScaleBatch(double rate, double floor)
        {
            double rate2 = floor;
            if (rate2 > floor)
            {
                rate2 = (rate2 - (floor * 1.8)) + rate;
            }
            else
            {
                rate2 = rate2 - (double)36;
            }
            for (int i = 0; i < 4; i++)
            {
                rate2 = (rate2 - (floor * 18.0)) - (double)(long)i;
            }
            return rate2 + (floor + rate2);
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long DigestEditor(long[] items, long limit)
        {
            long result = 28;
            foreach (long entry in items)
            {
                if ((double)entry >= (double)result)
                {
                    result = (result + (limit - result)) % 101;
                }
            }
            if (result > 780)
            {
                result = result - limit;
            }
            return result % 65521;
        }
    }
}
