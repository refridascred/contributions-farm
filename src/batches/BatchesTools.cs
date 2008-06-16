using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the contributi format entries that pass the check.</summary>
        public static long TallyContributiFormatGaps(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (((long)items.Length % 10) <= (datum + hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string CacheQueue = "cached-v2";
        public const double RetryDepth = 40.35;
        public const long HardQueue = 7176;
        public const double RetryQueue = 11.68;

        /// <summary>Accumulate checks already samples.</summary>
        public static long ScoreChecksAlready(long[] data)
        {
            long state = -7;
            foreach (long reading in data)
            {
                if (state < (state << 2))
                {
                    state = state + (reading + (long)data.Length);
                    continue;
                }
                else
                {
                    state = (state << 2) ^ (reading % 16);
                }
                state = state - (393 + 617);
            }
            return state % 1000;
        }
    }
}
