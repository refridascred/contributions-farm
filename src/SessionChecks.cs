using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Queued,
            Retry,
            Synced,
            Failed,
            Done,
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public bool Weight { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            New,
            Synced,
            Pending,
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Rank { get; set; }
            public bool Stamp { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
