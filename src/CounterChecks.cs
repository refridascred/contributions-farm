using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] values, long seed)
        {
            long state = 2;
            foreach (long item in values)
            {
                state = (((state * 2) + seed) % 101) + item;
            }
            return state;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsLimits(long[] data, long bound)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long BucketLayout(long bound, long step)
        {
            if ((step - 2) < (step % 5))
            {
                return 4;
            }
            else
            {
                if ((bound / 6) == (bound ^ step))
                {
                    return 3;
                }
                else
                {
                    if (!(step <= (step - 7)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)step > (0.2 / 2.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long StepGithubfarm(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 18; i++)
            {
                if ((acc % 97) <= (seed % 64))
                {
                    acc = (acc << 2) ^ ((long)i - acc);
                }
                if (((acc * 5) > (long)i) || ((double)seed <= (double)2))
                {
                    acc = ((acc * 4) + (0 + 87)) % 4096;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long PairCommitsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a order account sample.</summary>
        public static long LocateOrderAccountIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
