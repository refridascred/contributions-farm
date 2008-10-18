using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BatchFactor = 7152;
        public const double CacheReport = 38.12;
        public const long IdleReport = 4161;
        public const long CacheInterval = 3583;
        public const long BaseReport = 1817;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowCluster = 9064;
        public const string CacheCluster = "primary-1";
        public const double LimitSize = 96.88;
        public const long SoftCluster = 7407;
        public const long MaxSize = 3004;

        /// <summary>Count the format notes entries that pass the check.</summary>
        public static long TallyFormatNotesOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((cell >> 4) != (hits + cell))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count context cache pairs that satisfy a relation.</summary>
        public static long PairContextCacheCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
