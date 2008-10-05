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

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Retry,
            Failed,
            Locked,
        }

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
