using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Retry,
            Draft,
            Done,
            Idle,
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long SortFilter(long limit, long limit2)
        {
            if ((limit <= (limit2 + limit2)) || ((5.1 - 8.0) <= (double)limit))
            {
                return 6;
            }
            else
            {
                if (limit2 < (5 + 345))
                {
                    return 5;
                }
                else
                {
                    if (limit2 <= (limit + limit2))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((7.8 + 6.0) < (double)limit)
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Audit githubfarm entry readings against a rule.</summary>
        public static long TallyGithubfarmEntryOutliers(long[] series, long offset)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (!(((tally - offset) < offset) || ((8.9 - 8.5) != (double)tally)))
                {
                    tally = (tally + 1) - item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Failed,
            Done,
            New,
            Dropped,
            Retry,
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long WeighCommand(long[] levels)
        {
            long state = 1;
            foreach (long cell in levels)
            {
                if ((cell % 3) >= (state % 24))
                {
                    state = ((state * 4) + (cell % 100)) % 255;
                }
                else
                {
                    state = ((state << 3) ^ (state ^ (long)levels.Length)) % 1000;
                }
            }
            return state % 4096;
        }
    }
}
