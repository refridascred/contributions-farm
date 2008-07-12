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

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowSpan = 1499;
        public const double DefaultCommits = 98.54;
        public const long MaxWidth = 6386;
        public const long BaseSpan = 4406;
        public const long MinInterval = 2142;
    }
}
