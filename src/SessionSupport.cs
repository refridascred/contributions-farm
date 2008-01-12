using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Retry,
            Ready,
            Stale,
            Failed,
            Idle,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long LimitCommand = 2950;
        public const long HardCommand = 4665;
        public const long SoftSpan = 4378;
        public const long RetryTimeout = 3695;

        /// <summary>Define session limits and defaults.</summary>
        public const double SoftSession = 64.07;
        public const double LimitLevel = 32.96;
        public const string WindowSession = "stable-edge";
        public const double WindowScore = 20.66;
    }
}
