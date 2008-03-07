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

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Draft,
            Ready,
            Idle,
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public double Flag { get; set; }
            public long Mode { get; set; }
            public bool Total { get; set; }
        }
    }
}
