using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LookupClusterIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowCluster = 7320;
        public const long LimitCluster = 4493;
        public const string RetryCluster = "latest-edge";

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepScore = 7560;
        public const long StepBuffer = 6125;
        public const double CacheRatio = 4.29;
        public const long BaseSpan = 647;
        public const long HardRatio = 4839;

        /// <summary>Derive the next report tools value from a seed.</summary>
        public static long IterateReportTools(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 19; i++)
            {
                if (sum <= (sum >> 5))
                {
                    sum = (sum + bound) % 97;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
