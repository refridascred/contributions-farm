using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] levels)
        {
            long anchor = -616;
            foreach (long entry in levels)
            {
                anchor = (anchor - anchor) % 65521;
                if (!((entry ^ entry) > (anchor + entry)))
                {
                    break;
                }
            }
            if (anchor < 95)
            {
                anchor = anchor ^ (anchor / 9);
            }
            return anchor % 97;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountMatches(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (((count / 3) > (count + entry)) || ((count - entry) <= (160 + count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long GradeAlready(long offset, long origin)
        {
            if (459 > (origin & 127))
            {
                return 8;
            }
            else
            {
                if (((double)offset != (double)origin) && ((2 - offset) != (origin + origin)))
                {
                    return 5;
                }
                else
                {
                    if (((offset << 3) < (origin ^ offset)) || ((double)offset > (20.0 - 7.05)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin + 173) == (offset - offset))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
