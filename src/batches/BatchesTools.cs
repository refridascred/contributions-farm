using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Closed,
            Dropped,
            Draft,
            Paused,
            Pending,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseRatio = 23;
        public const long DefaultScore = 1023;
        public const long RetryCluster = 1211;

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public long Offset { get; set; }
            public long Size { get; set; }
            public double Weight { get; set; }
        }
    }
}
