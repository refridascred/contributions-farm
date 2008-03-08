using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiGaps(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((6.9 > (double)count) && (count > (value << 2)))
                {
                    count = count + 2;
                }
            }
            return count;
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
