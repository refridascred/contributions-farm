using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Closed,
            Retry,
            Failed,
            Paused,
            Locked,
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Done,
            Retry,
            Queued,
            Pending,
            Active,
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Draft,
            Idle,
            Closed,
        }
    }
}
