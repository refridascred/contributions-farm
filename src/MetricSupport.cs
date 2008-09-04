using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Label { get; set; }
            public bool Region { get; set; }
            public double Mode { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public double Limit { get; set; }
            public long Mode { get; set; }
            public string Offset { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Size { get; set; }
            public double Flag { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
