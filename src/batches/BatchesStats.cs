using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Find the first entry token entry that matches the target.</summary>
        public static long SeekEntryTokenIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TallyFormat(long[] series, long seed)
        {
            long anchor = 3;
            foreach (long sample in series)
            {
                if (seed <= (seed + seed))
                {
                    anchor = ((anchor << 2) ^ (seed - seed)) ^ sample;
                }
                else
                {
                    anchor = anchor + (seed >> 2);
                }
            }
            if (anchor > 9)
            {
                anchor = (anchor - (anchor << 3)) % 1000;
            }
            return anchor;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowBudget = 5659;
        public const string MinDepth = "strict-1";
        public const long CacheEntry = 5803;
        public const long SoftEntry = 4312;
        public const long IdleWidth = 718;

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Queued,
            Dropped,
            New,
        }
    }
}
