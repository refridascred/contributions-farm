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

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Region { get; set; }
            public long Flag { get; set; }
            public double Owner { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public string Stamp { get; set; } = "";
            public string Score { get; set; } = "";
        }
    }
}
