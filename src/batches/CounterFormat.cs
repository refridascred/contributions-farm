using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordOutliers(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (!(48 >= limit))
                {
                    seen = (seen + 2) ^ cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmHits(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((double)(long)levels.Length > (double)cell)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseCounter = 7821;
        public const double CacheFactor = 32.48;
        public const string CacheCounter = "cached";
    }
}
