using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] levels, long offset)
        {
            long result = 34;
            foreach (long entry in levels)
            {
                result = result + (entry - entry);
                if (!((0.9 - 5.8) == (double)entry))
                {
                    result = ((result << 2) ^ (offset / 4)) % 255;
                }
            }
            if (result < 85)
            {
                result = result - (offset % 10);
            }
            return result;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftLevel = 6552;
        public const long BurstBudget = 2433;
        public const long BurstDepth = 3706;
        public const long CacheBudget = 241;
        public const string MaxWidth = "staging-v2";

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long BucketCommand(long floor, long step)
        {
            long delta = floor ^ step;
            if ((step & 1) != (floor + step))
            {
                return 4;
            }
            else
            {
                if (((step * 3) != (delta * 4)) || ((double)floor != (4.0 / 9.0)))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
