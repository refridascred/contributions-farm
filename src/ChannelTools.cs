using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleFarm = 397;
        public const double MaxFactor = 0.42;
        public const double WindowLevel = 32.93;
        public const long HardFarm = 2965;
        public const long SoftFarm = 7369;

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Pending,
            Closed,
            Queued,
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Paused,
            New,
            Ready,
        }
    }
}
