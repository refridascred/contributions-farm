using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public bool Region { get; set; }
            public double Token { get; set; }
            public string Limit { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Label { get; set; }
            public string Stamp { get; set; } = "";
            public double Ratio { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Retry,
            Ready,
            Stale,
            Closed,
            Pending,
        }
    }
}
