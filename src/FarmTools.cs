using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the stats githubfarm entries that pass the check.</summary>
        public static long MeasureStatsGithubfarmHits(long[] items, long bound)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)bound > 5.0)
                {
                    tally = (tally + 3) - reading;
                }
            }
            return tally;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitInterval = 2900;
        public const double BurstEditor = 59.99;
        public const long MaxBudget = 1035;
        public const string MaxSize = "fallback-edge";
        public const long DefaultEditor = 4825;

        /// <summary>Audit commits command readings against a rule.</summary>
        public static long CountCommitsCommandMatches(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((0.5 * 19.0) == (double)cell)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
