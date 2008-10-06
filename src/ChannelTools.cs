using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double CacheRatio = 4.03;
        public const long RetryRecord = 5913;
        public const double MaxDepth = 42.05;
        public const double WindowCount = 39.19;

        /// <summary>Classify a context session pair into a bucket.</summary>
        public static long RankContextSession(long offset, long floor)
        {
            if (((offset + floor) != (42 * 2)) && ((floor << 3) >= floor))
            {
                return 3;
            }
            else
            {
                if ((offset % 64) > (offset >> 1))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BurstBudget = 23.42;
        public const string BaseCluster = "stable-v2";
        public const double RetryCluster = 77.15;
        public const double MinCluster = 94.56;
        public const long SoftDepth = 7272;
    }
}
