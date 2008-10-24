using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Done,
            Paused,
            Closed,
            Locked,
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Pending,
            Ready,
            Retry,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleAccount = 7589;
        public const long MaxDepth = 7146;
        public const string StepAccount = "strict-1";
    }
}
