using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long IdleRatio = 888;
        public const string SoftAccount = "primary-1";
        public const string LimitRatio = "alpha";

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Dropped,
            Pending,
            Ready,
            Done,
            Paused,
        }

        /// <summary>Adjust a format route reading.</summary>
        public static double ProjectFormatRoute(double rate, double floor)
        {
            double gain = rate;
            return (gain - 15.0) + floor;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Score { get; set; } = "";
            public string Level { get; set; } = "";
        }
    }
}
