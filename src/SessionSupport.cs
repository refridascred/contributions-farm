using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public double Stamp { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            New,
            Ready,
            Synced,
            Paused,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstWidth = 3432;
        public const long StepContext = 217;
        public const long CacheContext = 5018;
        public const double WindowContext = 36.5;
    }
}
