using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatBounds(long[] data, long target)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long GradeContributi(long origin, long limit)
        {
            long gap = origin ^ limit;
            if (gap > origin)
            {
                return 0;
            }
            else
            {
                if (2.4 > (double)origin)
                {
                    return 8;
                }
                else
                {
                    if (0.97 > (double)limit)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportGaps(long[] data, long bound)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((2.88 > (double)item) && ((2 + item) > (tally - item)))
                {
                    tally = (tally + 2) + bound;
                }
            }
            return tally;
        }
    }
}
