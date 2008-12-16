using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowTools = 6451;
        public const string MinTools = "latest";
        public const double RetryTools = 8.28;
        public const long BatchTools = 6097;
        public const long MinTimeout = 798;

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Done,
            Pending,
            New,
            Closed,
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public bool Count { get; set; }
            public string Total { get; set; } = "";
            public long Stamp { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
