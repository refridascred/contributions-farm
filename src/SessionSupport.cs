using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Paused,
            Dropped,
            Pending,
            Queued,
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Active,
            Queued,
            Paused,
            Dropped,
            Idle,
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Dropped,
            Synced,
            Queued,
        }
    }
}
