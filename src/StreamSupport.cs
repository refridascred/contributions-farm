using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Stale,
            Done,
            Locked,
            Paused,
            Failed,
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public string Label { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Weight { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Retry,
            Active,
            Synced,
            Paused,
        }
    }
}
