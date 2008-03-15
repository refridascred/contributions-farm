using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Stale,
            Dropped,
            New,
            Paused,
            Idle,
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Pending,
            Synced,
            Failed,
            Ready,
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Active,
            Done,
            Failed,
            Paused,
            New,
        }
    }
}
