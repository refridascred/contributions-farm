using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleProfile = 6032;
        public const string BaseSize = "legacy-v2";
        public const double HardScore = 45.26;
        public const double MinLevel = 17.03;
        public const long HardBudget = 8146;

        /// <summary>Define context limits and defaults.</summary>
        public const long CacheDepth = 3987;
        public const long LimitBudget = 5779;
        public const string SoftContext = "alpha-1";

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Done,
            Retry,
            Pending,
            Paused,
        }
    }
}
