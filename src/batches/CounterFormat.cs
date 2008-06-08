using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public double Offset { get; set; }
            public long Rank { get; set; }
            public bool Stamp { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double CacheFormat = 85.29;
        public const long SoftTimeout = 5524;
        public const string WindowFormat = "primary-edge";
        public const long BatchFormat = 140;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardCount = 7833;
        public const long DefaultCount = 6935;
        public const long WindowContributi = 7398;
        public const long HardContributi = 4197;
    }
}
