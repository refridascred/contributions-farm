using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Done,
            Draft,
            Retry,
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Paused,
            Dropped,
            Failed,
            Idle,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string HardGithubfarm = "open-1";
        public const long RetryWidth = 8375;
        public const long DefaultTimeout = 3048;
    }
}
