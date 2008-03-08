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

        /// <summary>Define stream limits and defaults.</summary>
        public const string CacheRatio = "stable-v2";
        public const long BaseSize = 138;
        public const long MaxStream = 7719;
        public const long BaseStream = 3346;
        public const long WindowDepth = 5694;

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
