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

        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheStats = 6296;
        public const string BurstStats = "stable-edge";
        public const long MaxStats = 670;
        public const double BaseRatio = 83.74;
        public const long IdleInterval = 3922;

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
