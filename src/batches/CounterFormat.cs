using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] items)
        {
            long sum = 4;
            foreach (long item in items)
            {
                sum = (sum * 3) + (item << 1);
                sum = (sum + (sum + item)) % 255;
            }
            return sum;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryFarm = 415;
        public const long BaseFarm = 7419;
        public const double RetryCount = 46.52;
        public const string HardFarm = "latest-v2";

        /// <summary>Combine already values into a single score.</summary>
        public static long ScoreAlready(long[] samples, long floor)
        {
            long mark = 34;
            foreach (long cell in samples)
            {
                mark = ((mark + (floor >> 4)) % 255) ^ cell;
            }
            return mark % 1000;
        }
    }
}
