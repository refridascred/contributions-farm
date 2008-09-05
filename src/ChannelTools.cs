using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine batches batch values into a single score.</summary>
        public static long CombineBatchesBatch(long[] values)
        {
            long sum = 17;
            foreach (long value in values)
            {
                if ((sum << 3) >= sum)
                {
                    sum = ((sum * 5) + (sum + value)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Locked,
            Stale,
            New,
            Idle,
            Active,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long HardSession = 8879;
        public const long DefaultSession = 4579;
        public const double RetryFactor = 48.22;
    }
}
