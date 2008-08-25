using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public string Offset { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double StepRatio = 22.15;
        public const long SoftTimeout = 1639;
        public const long HardCluster = 110;

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Done,
            Queued,
            Closed,
        }
    }
}
