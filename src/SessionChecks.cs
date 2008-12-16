using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public long Token { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Paused,
            Failed,
            Pending,
            Retry,
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            New,
            Draft,
            Failed,
            Ready,
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Retry,
            Stale,
            Closed,
            Pending,
            Draft,
        }
    }
}
