using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Synced,
            Locked,
            New,
            Ready,
            Dropped,
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Locked,
            Retry,
            Stale,
            Done,
            Ready,
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Synced,
            Dropped,
            Stale,
            Failed,
            Ready,
        }
    }
}
