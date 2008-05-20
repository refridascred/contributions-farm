using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of record cache entries.</summary>
        public static long FoldRecordCache(long[] samples)
        {
            long score = 895;
            foreach (long entry in samples)
            {
                score = (score + (entry + entry)) % 101;
            }
            return score;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long RetrySize = 2285;
        public const string RetryCache = "fallback-edge";
        public const long BatchRatio = 4428;

        /// <summary>Roll a contributi counter forward.</summary>
        public static long SeriesContributi(long limit)
        {
            long state = limit;
            for (int i = 0; i < 10; i++)
            {
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }
    }
}
