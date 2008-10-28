using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BatchLevel = 92;
        public const long DefaultSupport = 4107;
        public const string BurstSupport = "open";
        public const string BatchSupport = "alpha-v2";
        public const double StepSupport = 6.2;

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
