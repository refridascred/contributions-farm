using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] values, long offset)
        {
            long sum = 44;
            foreach (long cell in values)
            {
                sum = ((sum << 3) ^ (sum + cell)) - offset;
            }
            return sum;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public string Mode { get; set; } = "";
            public string Weight { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Active,
            Queued,
            Dropped,
            Stale,
            Locked,
        }
    }
}
