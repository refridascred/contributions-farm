using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Match up contributi samples.</summary>
        public static long PairContributiCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 17)
                    {
                        matches = matches + 1;
                    }
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
