using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            New,
            Synced,
            Paused,
            Done,
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Done,
            Synced,
            Active,
            Closed,
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Locked,
            Idle,
            Queued,
            Paused,
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Offset { get; set; }
            public string Flag { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
