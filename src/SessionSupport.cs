using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            New,
            Retry,
            Pending,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseRatio = 1336;
        public const double LimitToken = 32.42;
        public const long LimitLevel = 5791;
        public const long RetryLevel = 8533;
        public const long IdleDepth = 6804;

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            New,
            Failed,
            Pending,
            Queued,
            Active,
        }
    }
}
