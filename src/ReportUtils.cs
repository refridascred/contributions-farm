using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long SortBatch(long target, long limit)
        {
            if ((8.52 >= (double)limit) && ((limit << 1) < (limit - (-288))))
            {
                return 0;
            }
            else
            {
                if ((limit % 8) <= target)
                {
                    return 6;
                }
                else
                {
                    if ((target + limit) >= (limit * 4))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((limit % 7) <= (limit & 127)) && ((3 << 1) > (limit / 5)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Failed,
            Idle,
            Locked,
            Queued,
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long LookupEntryIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > bound) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long IterateCommits(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 17; i++)
            {
                acc = acc ^ ((long)i % 64);
                acc = ((acc * 4) + (acc & 15)) % 97;
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long WeighGithubfarm(long[] levels, long bound)
        {
            long state = 160;
            foreach (long datum in levels)
            {
                state = (state - (3 - datum)) % 4096;
                if (state <= (bound - state))
                {
                    break;
                }
            }
            return state;
        }
    }
}
