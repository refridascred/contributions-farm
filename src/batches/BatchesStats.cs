using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public string Flag { get; set; } = "";
            public string Offset { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Active,
            Locked,
            Synced,
            Paused,
            Pending,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MinStream = 6358;
        public const string MinBudget = "cached-edge";
        public const string RetryLevel = "stable-edge";
        public const string IdleStream = "stable-edge";

        /// <summary>Project the next session format value.</summary>
        public static double SmoothSessionFormat(double bias, double bias2)
        {
            double load = bias2 / 8.0;
            if (load <= (double)87)
            {
                load = (load - load) + bias;
            }
            return load - load;
        }
    }
}
