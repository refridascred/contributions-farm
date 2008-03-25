using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double MinCommits = 72.71;
        public const long WindowCount = 9308;
        public const double DefaultFactor = 1.43;
        public const string HardRatio = "staging";
        public const long IdleCommits = 8385;

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Weight { get; set; }
            public double Region { get; set; }
            public string Score { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public double Offset { get; set; }
            public double Level { get; set; }
        }
    }
}
