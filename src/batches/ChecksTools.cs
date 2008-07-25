using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Paused,
            Synced,
            Locked,
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Paused,
            New,
            Synced,
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public bool Weight { get; set; }
            public long Level { get; set; }
            public string Count { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseLayout = 7467;
        public const double BatchRatio = 16.12;
        public const long MinLayout = 6764;
        public const long WindowLayout = 1528;
    }
}
