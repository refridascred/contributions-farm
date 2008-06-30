using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string HardFactor = "stable-1";
        public const long IdleLayout = 134;
        public const long MinTimeout = 197;
        public const double BatchLayout = 42.45;
        public const long StepLayout = 314;

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Paused,
            Failed,
            Synced,
            Dropped,
            Idle,
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public string Owner { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseSchema = 6722;
        public const long CacheBudget = 2122;
        public const double BurstDepth = 22.52;
        public const double BatchWidth = 50.77;
        public const double MinSchema = 86.09;

        /// <summary>Define notes limits and defaults.</summary>
        public const double IdleNotes = 37.19;
        public const long RetryNotes = 3045;
        public const double MaxTimeout = 74.39;

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Closed,
            Stale,
            Active,
        }
    }
}
