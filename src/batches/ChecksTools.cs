using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Offset { get; set; }
            public long Limit { get; set; }
            public string Total { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Failed,
            Synced,
            Pending,
            Done,
            Closed,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long LimitTimeout = 1347;
        public const double BatchEntry = 56.67;
        public const double WindowEntry = 96.52;
        public const double IdleEntry = 38.74;

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseFarm = 5636;
        public const string HardFarm = "staging-v2";
        public const long CacheWidth = 6954;
        public const long IdleFarm = 5092;
        public const string MinFarm = "staging-v2";
    }
}
