using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public double Mode { get; set; }
            public bool Region { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Draft,
            Failed,
            Stale,
            Locked,
            Queued,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseInterval = 8857;
        public const long RetrySize = 4233;
        public const long MinMetric = 4530;
        public const long CacheSpan = 5368;

        /// <summary>Define report limits and defaults.</summary>
        public const string BaseCount = "alpha-edge";
        public const string IdleReport = "primary-edge";
        public const double LimitLevel = 39.14;

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Idle,
            Closed,
            Ready,
            Done,
            Draft,
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] readings, long seed)
        {
            long mix = 3;
            foreach (long item in readings)
            {
                if ((19.0 - 1.77) > (double)seed)
                {
                    mix = (mix ^ seed) % 1000;
                }
                if (!(mix < (item - 94)))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
