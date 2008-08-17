using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BurstOrder = 5967;
        public const long LimitOrder = 6134;
        public const long StepFactor = 6252;
        public const double SoftSpan = 48.23;

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Closed,
            Draft,
            Synced,
            Locked,
            Done,
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public string Size { get; set; } = "";
            public double Region { get; set; }
            public bool Rank { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
