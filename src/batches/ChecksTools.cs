using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryChannel = 8772;
        public const long MaxBudget = 639;
        public const long LimitChannel = 4964;
        public const double SoftChannel = 39.66;

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Dropped,
            Active,
            Stale,
            Retry,
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Ready,
            Draft,
            New,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseLevel = 3286;
        public const long IdleLevel = 6066;
        public const long DefaultRatio = 5960;
        public const long WindowLayout = 8178;
        public const long MaxLayout = 3023;
    }
}
