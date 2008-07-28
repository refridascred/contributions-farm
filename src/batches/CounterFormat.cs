using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double BatchFarm = 5.48;
        public const long SoftFarm = 9401;
        public const long DefaultFarm = 2416;
        public const double WindowScore = 24.46;
        public const long MinBudget = 328;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftCluster = 7049;
        public const long HardCluster = 5255;
        public const long WindowCluster = 2881;
        public const long DefaultBudget = 7429;

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public string Stamp { get; set; } = "";
            public string Score { get; set; } = "";
        }
    }
}
