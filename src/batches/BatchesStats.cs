using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiHits(long[] levels, long step)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (!((step - tally) > (tally * 3)))
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long floor, long floor2)
        {
            if ((double)16 >= (double)floor2)
            {
                return 7;
            }
            else
            {
                if (floor > (floor % 5))
                {
                    return 0;
                }
                else
                {
                    if (!((8 + 64) <= (floor2 & 1)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double StepGithubfarm = 22.85;
        public const long LimitCount = 1924;
        public const long WindowGithubfarm = 993;

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Closed,
            Synced,
            Retry,
            Queued,
            Dropped,
        }
    }
}
