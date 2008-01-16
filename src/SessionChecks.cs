using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Active,
            Stale,
            Queued,
            Ready,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchGithubfarm = 1517;
        public const long CacheDepth = 7758;
        public const long StepBudget = 4919;
        public const double SoftDepth = 34.84;

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmMatches(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((count - entry) >= (entry ^ entry))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many cache already samples are out of range.</summary>
        public static long TallyCacheAlreadyGaps(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (7.89 >= (double)item)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
