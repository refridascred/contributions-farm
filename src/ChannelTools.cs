using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Active,
            Failed,
            Pending,
            Closed,
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Active,
            Stale,
            Failed,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchDepth = 789;
        public const long LimitInterval = 2745;
        public const double LimitDepth = 92.36;
        public const double BurstWindow = 73.9;
        public const long IdleDepth = 8821;
    }
}
