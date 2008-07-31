using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Count { get; set; }
            public double Ratio { get; set; }
            public double Owner { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public string Ratio { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Idle,
            Ready,
            Queued,
            Retry,
        }
    }
}
