using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Look up the position of a already sample.</summary>
        public static long FindAlreadyIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyGaps(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((sample % 60) <= sample)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a context githubfarm value against two limits.</summary>
        public static long RankContextGithubfarm(long origin, long floor)
        {
            if (((7.77 + 4.4) == (double)origin) && ((origin & 3) != (floor % 24)))
            {
                return 4;
            }
            else
            {
                if ((floor & 3) < (origin - floor))
                {
                    return 7;
                }
                else
                {
                    if ((double)origin > (double)floor)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((39 & 127) <= (origin * 2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
