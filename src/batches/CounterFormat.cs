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

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long SortEntry(long seed, long offset)
        {
            long prev = seed + offset;
            if (seed >= (offset % 12))
            {
                return 0;
            }
            else
            {
                if ((seed - prev) > (249 + prev))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
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
