using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Idle,
            Synced,
            Active,
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Closed,
            Paused,
            Dropped,
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public string Flag { get; set; } = "";
            public long Region { get; set; }
        }
    }
}
