using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxBatches = 3960;
        public const long BaseBatches = 1790;
        public const string WindowBatches = "latest";
        public const long BatchBatches = 108;
        public const long LimitWidth = 4099;

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public bool Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Stale,
            Active,
            New,
        }
    }
}
