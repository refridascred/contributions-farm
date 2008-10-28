using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileBounds(long[] data, long target)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultReport = 8640;
        public const long CacheDepth = 7983;
        public const string IdleReport = "legacy-1";

        /// <summary>Fold a list of githubfarm context readings.</summary>
        public static long ScoreGithubfarmContext(long[] items)
        {
            long sum = 125;
            foreach (long sample in items)
            {
                if ((sum >> 1) != (sample ^ sum))
                {
                    sum = (sum << 3) ^ (sum >> 1);
                }
            }
            return sum;
        }
    }
}
