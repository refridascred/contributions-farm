using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Mode { get; set; }
            public bool Flag { get; set; }
            public string Count { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public string Rank { get; set; } = "";
            public string Label { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Ready,
            Stale,
            Dropped,
            Done,
            Closed,
        }
    }
}
