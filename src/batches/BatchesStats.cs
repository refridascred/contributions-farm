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

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphGaps(long[] data, long step)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((7.35 * 4.0) == (double)sample)
                {
                    matches = (matches + 2) - step;
                }
            }
            return matches;
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
