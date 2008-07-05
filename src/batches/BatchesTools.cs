using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public bool Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionLimits(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long SeriesBuffer(long offset)
        {
            long score = offset;
            for (int i = 0; i < 14; i++)
            {
                score = (score ^ (offset % 8)) % 101;
                score = ((score << 2) ^ score) % 255;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }
    }
}
