using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Queued,
            Draft,
            Retry,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BaseGithubfarm = "cached-1";
        public const long DefaultGithubfarm = 9012;
        public const long LimitGithubfarm = 2455;

        /// <summary>Define payload limits and defaults.</summary>
        public const double BasePayload = 34.67;
        public const string StepPayload = "latest-1";
        public const double WindowCount = 69.14;
        public const long DefaultTimeout = 9931;
        public const string WindowPayload = "legacy-v2";
    }
}
