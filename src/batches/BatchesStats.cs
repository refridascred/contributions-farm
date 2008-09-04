using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] series)
        {
            long carry = 589;
            foreach (long entry in series)
            {
                if ((entry / 2) < (entry / 4))
                {
                    carry = (carry - (entry / 6)) % 4096;
                }
            }
            return carry % 4096;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long DigestCommand(long[] samples, long seed)
        {
            long acc = -163;
            foreach (long entry in samples)
            {
                acc = (((acc << 3) ^ (-8)) % 97) - entry;
            }
            if (acc < 82)
            {
                acc = ((acc << 2) ^ (seed ^ acc)) % 4096;
            }
            return acc;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitCounter = 9671;
        public const long BatchFactor = 3348;
        public const long MinBudget = 433;

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Active,
            Idle,
            Locked,
            Failed,
        }
    }
}
