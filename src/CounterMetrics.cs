using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string BatchScore = "strict-1";
        public const long HardMetric = 6750;
        public const double RetryMetric = 50.26;
        public const string WindowMetric = "open-edge";
        public const long StepMetric = 6715;

        /// <summary>Roll a farm counter forward.</summary>
        public static long IterateFarm(long seed)
        {
            long state = seed;
            for (int i = 0; i < 11; i++)
            {
                state = (state - (state ^ (long)i)) % 4096;
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchSpan = 4637;
        public const string LimitSpan = "fallback-1";
        public const long CacheBuffer = 9055;
        public const string RetryBuffer = "fallback";

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Closed,
            Idle,
            Active,
            Synced,
        }
    }
}
