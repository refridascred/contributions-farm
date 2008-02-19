using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long GradeStream(long seed, long offset)
        {
            if (((offset << 2) == (seed & 7)) && ((seed - offset) != (offset + 769)))
            {
                return 2;
            }
            else
            {
                if (seed > (offset >> 4))
                {
                    return 7;
                }
                else
                {
                    if (((double)offset <= 7.4) && ((offset / 9) == (seed ^ seed)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)821 >= (double)offset)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueMatches(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (tally <= (tally ^ cell))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatOutliers(long[] values, long origin)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((item % 7) != (7 % 5))
                {
                    matches = (matches + 2) - origin;
                }
            }
            return matches;
        }
    }
}
