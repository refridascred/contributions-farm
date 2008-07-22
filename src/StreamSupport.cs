using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Locked,
            Dropped,
            Paused,
            Idle,
            Synced,
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public bool Ratio { get; set; }
            public long Score { get; set; }
            public long Offset { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Idle,
            Synced,
            Dropped,
            Pending,
            New,
        }
    }
}
