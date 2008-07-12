using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long MatchSupportCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowWidth = 4508;
        public const double LimitQueue = 91.7;
        public const long MaxTimeout = 7999;
        public const long CacheRatio = 9279;

        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] samples)
        {
            long acc = 53;
            foreach (long item in samples)
            {
                acc = (acc - (item >> 3)) % 255;
            }
            return acc % 1000;
        }
    }
}
