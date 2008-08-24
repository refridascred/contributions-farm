using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public bool Weight { get; set; }
            public bool Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Ratio { get; set; }
            public string Weight { get; set; } = "";
            public double Region { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double WindowBudget = 52.06;
        public const long CacheCount = 3187;
        public const long WindowFactor = 2627;
        public const double SoftGithubfarm = 15.08;

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Weight { get; set; }
            public string Total { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
