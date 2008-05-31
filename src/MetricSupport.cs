using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Closed,
            Locked,
            Failed,
            Ready,
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public string Region { get; set; } = "";
            public long Size { get; set; }
            public bool Score { get; set; }
        }

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
