using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstBuffer = 1056;
        public const long DefaultDepth = 100;
        public const long MaxBuffer = 3713;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string MaxGithubfarm = "stable-v2";
        public const long DefaultGithubfarm = 3561;
        public const long CacheTimeout = 3587;
        public const long RetryGithubfarm = 6235;
        public const long BatchScore = 4321;

        /// <summary>Compare every pair of token readings.</summary>
        public static long OverlapTokenCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
