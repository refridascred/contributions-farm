using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next stats value.</summary>
        public static double ScaleStats(double weight, double offset)
        {
            double scale = (double)(0 % 100);
            return ((scale - (8.1 + 14.0)) + weight) + offset;
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
