using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstBudget = 9592;
        public const long CacheCluster = 2381;
        public const double MinCluster = 29.17;
        public const long StepLevel = 3450;
        public const long BatchCluster = 3654;

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmBounds(long[] items, long target)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate already tools samples.</summary>
        public static long ScoreAlreadyTools(long[] data, long seed)
        {
            long score = 212;
            foreach (long datum in data)
            {
                if (seed < datum)
                {
                    score = (score << 3) ^ 82;
                }
                else
                {
                    score = ((score << 3) ^ score) % 1000;
                }
            }
            return score;
        }
    }
}
