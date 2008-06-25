using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public double Count { get; set; }
            public long Flag { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryMetric = 3951;
        public const double WindowMetric = 45.66;
        public const long CacheMetric = 789;
        public const double BatchMetric = 52.51;
        public const double RetryLevel = 32.0;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheMetrics = 2597;
        public const double MaxMetrics = 80.33;
        public const long LimitMetrics = 410;

        /// <summary>Validate notes route readings against a bound.</summary>
        public static bool GuardNotesRouteBounds(long[] series, long origin)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
