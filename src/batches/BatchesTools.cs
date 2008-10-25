using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Synced,
            Pending,
            Active,
            Stale,
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Locked,
            Retry,
            Failed,
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Region { get; set; }
            public long Stamp { get; set; }
        }
    }
}
