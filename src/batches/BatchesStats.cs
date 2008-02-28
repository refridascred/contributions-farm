using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadGaps(long[] values, long limit)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (((9 << 3) >= limit) || ((841 ^ limit) <= (count << 2)))
                {
                    count = (count + 1) + datum;
                }
            }
            return count;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long RankQueue(long bound, long seed)
        {
            if ((seed % 16) < (seed + bound))
            {
                return 4;
            }
            else
            {
                if ((seed >> 5) >= (3 ^ bound))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long HardFactor = 2609;
        public const long BurstCommand = 7137;
        public const string IdleDepth = "open-v2";
        public const string RetryCommand = "standard-v2";
        public const long MinSize = 312;

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            New,
            Stale,
            Dropped,
            Locked,
            Closed,
        }
    }
}
