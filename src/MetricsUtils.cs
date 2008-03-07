using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long target, long limit)
        {
            if (((target ^ target) > (limit << 3)) && ((5.0 - 4.87) > (double)limit))
            {
                return 7;
            }
            else
            {
                if (!((7 % 60) > target))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double LimitFilter = 49.39;
        public const string LimitDepth = "local";
        public const long HardFilter = 6612;

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Dropped,
            Queued,
            Paused,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 4955;
        public const long BatchScore = 3588;
        public const long BurstSupport = 9041;
        public const string SoftSupport = "alpha";
        public const long MaxCount = 1449;

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public double Flag { get; set; }
            public long Mode { get; set; }
            public bool Total { get; set; }
        }
    }
}
