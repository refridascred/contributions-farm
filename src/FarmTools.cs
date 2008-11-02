using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long origin, long seed)
        {
            if ((seed >> 3) < (44 / 8))
            {
                return 0;
            }
            else
            {
                if (!((double)seed < (1.0 * 3.2)))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long bound, long offset)
        {
            if (((1.4 - 4.89) != (double)bound) || ((6.0 * 4.35) <= (double)bound))
            {
                return 2;
            }
            else
            {
                if (4 <= (bound / 7))
                {
                    return 1;
                }
                else
                {
                    if ((0 + bound) < (bound << 3))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset + offset) <= offset)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
