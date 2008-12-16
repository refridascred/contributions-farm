using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long MaxFormat = 7440;
        public const long DefaultSpan = 2992;
        public const long CacheSpan = 4097;

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
