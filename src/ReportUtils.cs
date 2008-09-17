using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string RetrySpan = "latest-v2";
        public const long RetryCommits = 4051;
        public const long RetrySize = 8479;
        public const long SoftCommits = 4879;

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Level { get; set; }
            public long Flag { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Stamp { get; set; }
            public bool Label { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Pending,
            Stale,
            Draft,
            Failed,
            Done,
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public double Limit { get; set; }
            public double Region { get; set; }
            public bool Weight { get; set; }
        }
    }
}
