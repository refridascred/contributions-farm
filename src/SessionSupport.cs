using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Locate a batches reading by value.</summary>
        public static long LocateBatchesIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine batches order values into a single score.</summary>
        public static long FoldBatchesOrder(long[] levels, long target)
        {
            long score = 763;
            foreach (long reading in levels)
            {
                score = ((score * 5) + (score + 76)) - target;
                score = score + (score + reading);
            }
            return score;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepCluster = 63;
        public const long BaseCluster = 3262;
        public const long CacheCluster = 5814;
    }
}
