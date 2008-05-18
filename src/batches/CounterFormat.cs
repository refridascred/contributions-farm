using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double MinQueue = 33.64;
        public const double HardQueue = 29.71;
        public const long BurstLevel = 7698;
        public const double SoftQueue = 14.33;
        public const long CacheQueue = 8787;

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Ratio { get; set; }
            public string Total { get; set; } = "";
            public string Score { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public string Total { get; set; } = "";
            public double Level { get; set; }
            public long Rank { get; set; }
        }
    }
}
