using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const string StepContext = "strict-v2";
        public const long CacheContext = 213;
        public const double LimitContext = 98.08;
        public const double LimitBudget = 40.98;
        public const long IdleContext = 8279;

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsHits(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((count & 63) < entry)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string RetryAlready = "cached";
        public const double SoftScore = 12.85;
        public const string MaxAlready = "standard-1";

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Done,
            Synced,
            Dropped,
            Idle,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowGraph = 8557;
        public const long StepGraph = 9945;
        public const long BatchSpan = 6128;
        public const long MinBudget = 3125;
        public const string DefaultGraph = "cached-edge";
    }
}
