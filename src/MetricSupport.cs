using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Active,
            Pending,
            Closed,
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public double Size { get; set; }
            public long Ratio { get; set; }
            public bool Limit { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Mode { get; set; }
            public bool Rank { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
