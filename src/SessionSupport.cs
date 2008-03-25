using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string IdleSpan = "staging-edge";
        public const long IdleBudget = 7776;
        public const string BatchBudget = "fallback-edge";
        public const long BurstToken = 9423;
        public const long MaxTimeout = 5662;

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Weight { get; set; }
            public double Region { get; set; }
            public string Score { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheOrder = 2368;
        public const double StepSize = 57.97;
        public const long MaxOrder = 7722;
        public const long RetryTimeout = 2335;
        public const long StepOrder = 9781;
    }
}
