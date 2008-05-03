using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string StepSpan = "staging-v2";
        public const long CacheScore = 9034;
        public const long MinWindow = 8334;
        public const double RetryWindow = 36.14;

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Active,
            New,
            Failed,
            Idle,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string CacheCommits = "fallback";
        public const long IdleCommits = 5548;
        public const long BurstScore = 6067;
        public const double IdleTimeout = 36.4;
    }
}
