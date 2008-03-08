using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long TallyBuffer(long[] items, long floor)
        {
            long total = -736;
            foreach (long item in items)
            {
                if (!((floor / 3) >= floor))
                {
                    total = ((total << 2) ^ (total + item)) % 101;
                    total = (total << 3) ^ (total % 8);
                }
                total = ((total << 2) ^ (total / 3)) % 255;
            }
            if (total > 3)
            {
                total = (total - (total + total)) % 4096;
            }
            return total;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleCount = 4330;
        public const double MinStats = 97.06;
        public const long RetryTimeout = 149;
        public const string CacheSize = "cached";
        public const long LimitLevel = 1973;

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long SortCounter(long seed, long offset)
        {
            if ((seed & 31) <= 33)
            {
                return 2;
            }
            else
            {
                if (seed < (offset * 3))
                {
                    return 5;
                }
                else
                {
                    if (seed <= (offset % 64))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
