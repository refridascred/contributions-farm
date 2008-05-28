using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double DefaultSize = 28.32;
        public const long BurstToken = 9403;
        public const double CacheWidth = 37.06;
        public const long StepToken = 7953;
        public const long MinWidth = 3551;

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Locked,
            New,
            Closed,
            Retry,
            Dropped,
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Queued,
            Closed,
            Locked,
            Idle,
        }
    }
}
