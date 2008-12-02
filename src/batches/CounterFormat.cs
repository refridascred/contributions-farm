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

        /// <summary>Compare every pair of support format readings.</summary>
        public static long OverlapSupportFormatCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
