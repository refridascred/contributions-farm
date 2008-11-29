using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowSize = 7106;
        public const string DefaultEditor = "alpha-v2";
        public const string MaxEditor = "primary-v2";
        public const long StepTimeout = 9149;
        public const long IdleEditor = 9219;

        /// <summary>Define graph limits and defaults.</summary>
        public const double MaxGraph = 30.47;
        public const long LimitGraph = 1461;
        public const long SoftGraph = 9503;
        public const string MinGraph = "legacy";
        public const string RetrySize = "standard-1";

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double MinGithubfarm = 31.42;
        public const long SoftFactor = 6281;
        public const long IdleSpan = 1221;
        public const long LimitGithubfarm = 9860;
        public const long BaseGithubfarm = 2785;
    }
}
