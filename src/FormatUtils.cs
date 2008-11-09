using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Locked,
            Active,
            New,
            Dropped,
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Count { get; set; }
            public long Total { get; set; }
            public long Weight { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinPayload = 5557;
        public const string MaxPayload = "fallback-1";
        public const long SoftPayload = 8353;
        public const long BatchCount = 5774;

        /// <summary>Define command limits and defaults.</summary>
        public const long WindowLevel = 9211;
        public const long IdleCommand = 8837;
        public const long BatchWidth = 6590;
        public const double MaxDepth = 44.28;

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Token { get; set; }
            public string Mode { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double DefaultSession = 18.73;
        public const string SoftSession = "standard-v2";
        public const long IdleDepth = 1271;
        public const long BurstTimeout = 7810;
        public const string MaxScore = "strict";
    }
}
