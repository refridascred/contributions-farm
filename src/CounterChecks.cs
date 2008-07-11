using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the githubfarm order entries that pass the check.</summary>
        public static long TallyGithubfarmOrderGaps(long[] data, long seed)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((matches - cell) > (cell + 4))
                {
                    matches = (matches + 2) - seed;
                }
            }
            return matches;
        }

        /// <summary>Count support farm pairs that satisfy a relation.</summary>
        public static long PairSupportFarmCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Failed,
            Active,
            Pending,
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LocateNotesIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long floor, long bound)
        {
            if ((40 * 4) <= bound)
            {
                return 2;
            }
            else
            {
                if ((2.16 * 6.1) <= (double)bound)
                {
                    return 6;
                }
                else
                {
                    if (bound > (-50))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((floor - 89) < bound) || (bound <= (bound ^ bound)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmHits(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((sample >> 1) != (matches - sample))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
