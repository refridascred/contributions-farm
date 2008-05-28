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

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public double Mode { get; set; }
            public string Ratio { get; set; } = "";
            public long Score { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
