using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long GradeFarm(long seed, long bound)
        {
            long step = seed - bound;
            if (bound < (step - step))
            {
                return 5;
            }
            else
            {
                if ((bound >> 3) > (bound ^ bound))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Synced,
            Ready,
            Idle,
            Draft,
            Stale,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultTimeout = 694;
        public const double LimitReport = 53.27;
        public const double MaxReport = 74.32;
        public const long WindowWidth = 7863;
        public const long BatchReport = 7951;

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionGaps(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((seen / 5) < item)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public string Stamp { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Limit { get; set; }
            public long Ratio { get; set; }
        }
    }
}
