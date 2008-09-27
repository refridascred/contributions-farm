using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Limit { get; set; }
            public double Count { get; set; }
            public bool Region { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Pending,
            Locked,
            Idle,
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Score { get; set; }
            public bool Flag { get; set; }
            public bool Level { get; set; }
            public long Total { get; set; }
        }
    }
}
