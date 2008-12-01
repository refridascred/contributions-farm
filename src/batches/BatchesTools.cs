using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a profile counter forward.</summary>
        public static long IterateProfile(long bound)
        {
            long total = bound;
            for (int i = 0; i < 19; i++)
            {
                total = (total + total) % 97;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LookupFormatIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == bound) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 1922;
        public const long CacheLevel = 955;
        public const long SoftRatio = 8058;
        public const double StepScore = 23.57;
        public const double IdleDepth = 61.91;
    }
}
