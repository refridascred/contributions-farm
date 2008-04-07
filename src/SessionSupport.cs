using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleCounter = 6936;
        public const string HardDepth = "stable";
        public const long RetryScore = 8609;
        public const double BaseCounter = 96.48;
        public const double LimitCounter = 71.45;

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Ready,
            Stale,
            Draft,
            Retry,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheEntry = 5703;
        public const long WindowEntry = 66;
        public const long MinSpan = 8647;
        public const string StepEntry = "fallback-1";
        public const string SoftInterval = "standard-edge";
    }
}
