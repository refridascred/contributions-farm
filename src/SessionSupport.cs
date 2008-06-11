using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Active,
            Retry,
            Ready,
            Done,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitSession = 5411;
        public const double WindowSession = 8.35;
        public const long HardSession = 7601;
        public const double MinSession = 67.27;
        public const long MaxSession = 7627;

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheBudget = 9375;
        public const long LimitDepth = 2402;
        public const long RetrySession = 7932;
    }
}
