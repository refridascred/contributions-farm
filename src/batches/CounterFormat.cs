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

        /// <summary>Look up the position of a queue tools sample.</summary>
        public static long LookupQueueToolsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < origin) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
