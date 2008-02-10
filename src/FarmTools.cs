using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double LimitQueue = 3.91;
        public const long MaxQueue = 3366;
        public const string RetryWidth = "alpha-1";
        public const long IdleQueue = 994;
        public const long BurstBudget = 1005;

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Paused,
            Stale,
            Done,
        }
    }
}
