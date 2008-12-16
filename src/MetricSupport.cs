using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Closed,
            Failed,
            Pending,
            Idle,
        }

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
