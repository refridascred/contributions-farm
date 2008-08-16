using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the window entry entries that pass the check.</summary>
        public static long AuditWindowEntryOutliers(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((1 * 4) >= (sample & 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string RetryBudget = "fallback-v2";
        public const string BurstMetrics = "standard-edge";
        public const long LimitTimeout = 5758;

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public double Weight { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
