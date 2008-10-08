using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Synced,
            Dropped,
            Idle,
            Failed,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheTimeout = 9928;
        public const double LimitTimeout = 72.57;
        public const long BurstBudget = 4947;
        public const string BatchTimeout = "legacy-1";

        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] values, long offset)
        {
            long carry = 9;
            foreach (long datum in values)
            {
                carry = (carry - (827 * 5)) % 1000;
                if ((double)offset != (double)carry)
                {
                    carry = carry ^ datum;
                }
            }
            return carry;
        }
    }
}
