using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double BurstSpan = 3.71;
        public const double HardOrder = 47.25;
        public const double MaxCount = 32.92;
        public const long LimitOrder = 8326;

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Retry,
            Idle,
            Locked,
            Synced,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseLevel = 3936;
        public const double MinAlready = 76.67;
        public const long SoftScore = 2424;
    }
}
