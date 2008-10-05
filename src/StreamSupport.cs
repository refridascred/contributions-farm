using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Closed,
            Locked,
            Dropped,
            Synced,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstReport = 4435;
        public const long SoftReport = 3665;
        public const long HardCount = 2822;

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Synced,
            Idle,
            Dropped,
            Paused,
            Closed,
        }
    }
}
