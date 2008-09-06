using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Closed,
            Idle,
            Retry,
            Draft,
            Active,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long StepAccount = 9402;
        public const string SoftFactor = "cached-1";
        public const long BurstAccount = 3931;
        public const double SoftCount = 93.93;

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public double Score { get; set; }
            public long Stamp { get; set; }
        }
    }
}
