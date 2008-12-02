using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string BaseRecord = "open-1";
        public const double BatchSize = 90.9;
        public const long MinRecord = 5700;
        public const long MaxRatio = 3344;
        public const string DefaultRecord = "alpha";

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long SeriesCommits(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 21; i++)
            {
                if (((6 - 35) == (long)i) || (origin < (596 + carry)))
                {
                    break;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
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
