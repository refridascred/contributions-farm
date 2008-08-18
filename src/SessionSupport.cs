using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Ready,
            Locked,
            Done,
            Pending,
            Synced,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double HardTools = 72.22;
        public const long SoftLevel = 9639;
        public const long WindowSize = 1856;

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            New,
            Pending,
            Draft,
            Dropped,
            Queued,
        }
    }
}
