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

        /// <summary>Define farm limits and defaults.</summary>
        public const string WindowSize = "alpha-edge";
        public const long HardFarm = 4736;
        public const double MaxScore = 64.5;
        public const long BaseInterval = 2700;
    }
}
