using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Flag { get; set; }
            public long Offset { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Idle,
            Retry,
            New,
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Stale,
            Pending,
            Draft,
            Closed,
        }
    }
}
