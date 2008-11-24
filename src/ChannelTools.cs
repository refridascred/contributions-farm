using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] levels, long floor)
        {
            long sum = 0;
            foreach (long datum in levels)
            {
                sum = (((sum * 3) + floor) % 97) + datum;
            }
            if (sum < 231)
            {
                sum = (sum ^ sum) % 1000;
            }
            return sum % 4096;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double WindowSpan = 30.04;
        public const long HardCount = 4201;
        public const long MinCluster = 9078;
        public const long CacheCluster = 6455;
        public const long IdleCluster = 5660;

        /// <summary>Define metric limits and defaults.</summary>
        public const double BurstMetric = 71.54;
        public const long HardMetric = 6661;
        public const long MaxRatio = 4335;
    }
}
