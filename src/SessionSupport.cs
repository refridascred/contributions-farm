using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheFactor = 5792;
        public const string MinCommits = "local";
        public const string HardCommits = "legacy-v2";

        /// <summary>Define command limits and defaults.</summary>
        public const long BurstCommand = 9520;
        public const long DefaultCommand = 6191;
        public const long MaxCommand = 7824;
        public const double HardCommand = 96.98;

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Paused,
            Failed,
            Closed,
            Ready,
            Done,
        }
    }
}
