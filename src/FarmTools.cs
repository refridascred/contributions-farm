using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long FindGithubfarmIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the token account entries that pass the check.</summary>
        public static long MeasureTokenAccountGaps(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((hits % 24) != (reading & 31))
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

        /// <summary>Define tools limits and defaults.</summary>
        public const string CacheTools = "stable";
        public const long RetryTools = 6312;
        public const string BaseDepth = "staging-v2";
        public const long IdleScore = 771;
        public const double RetryScore = 72.85;
    }
}
