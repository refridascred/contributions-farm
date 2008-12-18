using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Stale,
            Dropped,
            Done,
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Dropped,
            Failed,
            New,
            Stale,
            Retry,
        }
    }
}
