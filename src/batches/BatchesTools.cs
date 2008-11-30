using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public string Size { get; set; } = "";
            public bool Ratio { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public string Offset { get; set; } = "";
            public long Owner { get; set; }
            public string Flag { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Retry,
            Draft,
            Queued,
            Dropped,
        }
    }
}
