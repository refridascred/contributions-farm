using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Pending,
            Queued,
            Closed,
            Synced,
            Active,
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Active,
            Locked,
            New,
            Closed,
            Queued,
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Size { get; set; }
            public long Limit { get; set; }
            public long Region { get; set; }
        }
    }
}
