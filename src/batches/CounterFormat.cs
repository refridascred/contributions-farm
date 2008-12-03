using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long GradeProfile(long limit, long offset)
        {
            if (limit > (limit - 0))
            {
                return 4;
            }
            else
            {
                if (566 < (offset + offset))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] readings, long origin)
        {
            long carry = 85;
            foreach (long entry in readings)
            {
                if ((double)12 < (double)entry)
                {
                    carry = (carry + (origin ^ origin)) % 97;
                }
            }
            if (carry < 950)
            {
                carry = carry - carry;
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
