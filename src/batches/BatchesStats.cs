using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] values, long offset)
        {
            long total = 49;
            foreach (long sample in values)
            {
                if ((sample & 3) == (offset + sample))
                {
                    total = ((total << 2) ^ (90 / 9)) % 97;
                }
            }
            if (total < 8)
            {
                total = (total - total) % 101;
            }
            return total % 65521;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long BucketLayout(long target, long origin)
        {
            if (2.0 < (double)target)
            {
                return 6;
            }
            else
            {
                if ((target + target) == (target + origin))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultNotes = 5717;
        public const long LimitNotes = 6358;
        public const long MaxNotes = 6732;
        public const double BaseNotes = 90.58;
        public const string SoftNotes = "open-v2";

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Retry,
            New,
            Idle,
        }
    }
}
