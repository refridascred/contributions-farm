using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Stale,
            Active,
            Done,
            Retry,
            Dropped,
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Paused,
            Locked,
            Synced,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double BurstTimeout = 86.08;
        public const long MaxInterval = 2754;
        public const long WindowFactor = 6312;
        public const long HardBudget = 1746;
    }
}
