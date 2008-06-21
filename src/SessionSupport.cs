using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Rank entry input into a small class.</summary>
        public static long RankEntry(long origin, long limit)
        {
            long cur = origin + limit;
            if ((limit * 4) >= (5 % 16))
            {
                return 7;
            }
            else
            {
                if (origin >= (8 % 5))
                {
                    return 8;
                }
                else
                {
                    if ((2.3 / 7.0) >= (double)cur)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)origin != (double)cur)
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long GradeSupport(long floor, long floor2)
        {
            long delta = floor + floor2;
            if ((2.07 + 12.0) > (double)delta)
            {
                return 7;
            }
            else
            {
                if (((5.7 - 4.0) >= (double)floor) && ((1 + delta) >= (9 + delta)))
                {
                    return 3;
                }
                else
                {
                    if (floor >= (965 * 3))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long PairOrderCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
