using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Stale,
            New,
            Idle,
            Active,
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Paused,
            Ready,
            Closed,
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public string Size { get; set; } = "";
            public long Owner { get; set; }
            public bool Ratio { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheEntry = 4341;
        public const long BurstEntry = 8268;
        public const long HardScore = 9606;
    }
}
