using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Synced,
            Pending,
            Closed,
            Draft,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string WindowLevel = "local-edge";
        public const long IdleDepth = 1057;
        public const long BurstSpan = 5274;
        public const string MinLayout = "primary";
        public const long RetryWidth = 3529;

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public double Total { get; set; }
            public double Owner { get; set; }
            public double Limit { get; set; }
            public bool Offset { get; set; }
        }
    }
}
