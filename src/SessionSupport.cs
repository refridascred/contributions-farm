using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Stale,
            Active,
            Idle,
            Locked,
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            New,
            Paused,
            Draft,
            Locked,
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Queued,
            Locked,
            Pending,
        }
    }
}
