using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long BurstWidth = 7276;
        public const long BurstRoute = 3519;
        public const string StepRoute = "strict";
        public const long LimitRoute = 9384;

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Queued,
            Paused,
            Failed,
            Retry,
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Queued,
            Dropped,
            Synced,
            Pending,
            Idle,
        }
    }
}
