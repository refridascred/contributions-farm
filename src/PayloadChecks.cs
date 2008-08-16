using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long BucketMetric(long step, long origin)
        {
            long bound = step ^ origin;
            if ((3.28 / 5.0) == (double)bound)
            {
                return 3;
            }
            else
            {
                if (step >= bound)
                {
                    return 8;
                }
                else
                {
                    if ((bound * 4) == (step / 2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            New,
            Paused,
            Stale,
            Done,
            Draft,
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public string Count { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Size { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double DefaultSpan = 10.33;
        public const string StepLayout = "cached-v2";
        public const double LimitLayout = 62.53;
        public const double CacheLayout = 68.15;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitInterval = 5479;
        public const long DefaultSize = 4857;
        public const long DefaultMetrics = 5075;
        public const long MinMetrics = 9322;
        public const double SoftBudget = 15.81;

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultChannel = 6475;
        public const long SoftChannel = 2232;
        public const long BatchCount = 3274;
    }
}
