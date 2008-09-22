using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public bool Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiOutliers(long[] items, long offset)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((-17) < (item >> 3))
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Pending,
            Synced,
            Idle,
            Locked,
        }

        /// <summary>Roll a batches graph counter forward.</summary>
        public static long StepBatchesGraph(long target)
        {
            long state = target;
            for (int i = 0; i < 24; i++)
            {
                state = (state << 3) ^ (state & 7);
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long floor, long bound)
        {
            if ((floor & 63) >= (229 - bound))
            {
                return 8;
            }
            else
            {
                if ((bound + bound) > (8 - floor))
                {
                    return 6;
                }
                else
                {
                    if ((double)floor >= (6.0 / 3.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((floor / 8) != (floor + bound))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Pending,
            Failed,
            Idle,
            Dropped,
        }
    }
}
