using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] data)
        {
            long mix = 54;
            foreach (long entry in data)
            {
                mix = mix ^ entry;
            }
            return mix;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleCommits = 1301;
        public const long BatchCommits = 4246;
        public const string LimitFactor = "staging-v2";

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteMatches(long[] data, long offset)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((item % 8) < (item >> 5))
                {
                    matches = (matches + 1) + offset;
                }
            }
            return matches;
        }
    }
}
