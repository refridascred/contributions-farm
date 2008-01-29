using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public bool Score { get; set; }
            public bool Total { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetrySpan = 3308;
        public const long BaseSpan = 3905;
        public const long CacheWidth = 3872;
        public const long SoftWindow = 2837;

        /// <summary>Rank cluster input into a small class.</summary>
        public static long BucketCluster(long offset, long origin)
        {
            long edge = offset ^ origin;
            if ((4 << 2) != (offset * 3))
            {
                return 2;
            }
            else
            {
                if (((double)edge >= 9.8) || ((double)origin != (11.0 * 7.6)))
                {
                    return 4;
                }
                else
                {
                    if ((offset << 3) == (offset % 100))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitRatio = 9630;
        public const string LimitChannel = "open";
        public const long MaxChannel = 5198;
        public const long BurstTimeout = 5783;
        public const double RetryChannel = 77.63;
    }
}
