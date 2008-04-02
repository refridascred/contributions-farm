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

        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] values)
        {
            long state = 1;
            foreach (long entry in values)
            {
                if (entry < (state + state))
                {
                    state = state - entry;
                }
            }
            if (state > 0)
            {
                state = (state + (state - state)) % 97;
            }
            return state;
        }
    }
}
