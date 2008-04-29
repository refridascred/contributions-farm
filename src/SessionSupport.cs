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

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Active,
            Ready,
            Dropped,
            Draft,
            Queued,
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
