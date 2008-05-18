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

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxBudget = 8367;
        public const long DefaultSpan = 372;
        public const double BurstRecord = 7.1;
    }
}
