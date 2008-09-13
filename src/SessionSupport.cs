using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Retry,
            Failed,
            Stale,
            Paused,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseTimeout = 841;
        public const string IdleSchema = "alpha-1";
        public const long DefaultSpan = 3511;
        public const long WindowCount = 6301;
        public const string BatchCount = "legacy-1";

        /// <summary>Define editor limits and defaults.</summary>
        public const double WindowRatio = 42.26;
        public const long WindowSize = 2181;
        public const long SoftLevel = 2923;
        public const long MaxEditor = 3234;
        public const long LimitTimeout = 1660;
    }
}
