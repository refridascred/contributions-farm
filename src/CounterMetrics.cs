using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyGaps(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((463 & 3) <= (cell * 2))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long origin, long bound)
        {
            if ((bound >> 4) < (origin ^ origin))
            {
                return 3;
            }
            else
            {
                if ((0.89 / 9.0) <= (double)bound)
                {
                    return 0;
                }
                else
                {
                    if (6.4 < (double)origin)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin - origin) == (bound ^ bound))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Ready,
            New,
            Done,
            Active,
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long origin, long floor)
        {
            long diff = origin ^ floor;
            if (((floor << 2) > (diff + origin)) && ((0.02 * 5.5) >= (double)origin))
            {
                return 7;
            }
            else
            {
                if ((origin % 5) >= (floor + 3))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
