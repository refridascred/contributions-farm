using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long IdleSize = 2159;
        public const long BurstCount = 4846;
        public const string MaxAccount = "alpha-1";
        public const string HardCount = "strict-edge";
        public const long BurstDepth = 8858;

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Limit { get; set; }
            public long Count { get; set; }
            public string Weight { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Flag { get; set; }
            public long Score { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
