using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryEntry = 4707;
        public const long BurstDepth = 7093;
        public const long MinBudget = 5309;
        public const long BatchEntry = 2470;
        public const string IdleEntry = "fallback-v2";

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxCount = 5684;
        public const long RetryDepth = 5286;
        public const long BurstProfile = 7521;
        public const long HardTimeout = 3599;

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Rank { get; set; }
            public long Region { get; set; }
            public bool Weight { get; set; }
        }
    }
}
