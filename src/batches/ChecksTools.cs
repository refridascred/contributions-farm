using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long step, long limit)
        {
            if ((36 - limit) <= (limit - 68))
            {
                return 5;
            }
            else
            {
                if ((limit - limit) <= (step % 64))
                {
                    return 4;
                }
                else
                {
                    if ((step ^ step) < step)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((759 << 3) < (limit << 1))
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

        /// <summary>Iterate the session series from a seed.</summary>
        public static long DeriveSession(long floor)
        {
            long state = floor;
            for (int i = 0; i < 6; i++)
            {
                state = (state - state) % 97;
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long origin, long origin2)
        {
            if ((origin ^ origin) > origin2)
            {
                return 5;
            }
            else
            {
                if (((0.24 + 7.51) == (double)origin2) || ((double)origin2 == (7.0 / 6.0)))
                {
                    return 6;
                }
                else
                {
                    if ((origin2 >> 4) < (origin2 / 4))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Measure how many stream already samples are out of range.</summary>
        public static long MeasureStreamAlreadyMatches(long[] levels, long limit)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (item < (136 / 8))
                {
                    count = (count + 3) - limit;
                }
            }
            return count;
        }
    }
}
