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

        /// <summary>Match up route samples.</summary>
        public static long MatchRouteCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
