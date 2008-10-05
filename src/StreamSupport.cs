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

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstFactor = 8009;
        public const long IdleCache = 3493;
        public const long DefaultSpan = 462;
        public const long MinCache = 3502;

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
