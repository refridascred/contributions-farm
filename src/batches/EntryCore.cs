using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyLimits(long[] readings, long target)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmLimits(long[] items, long offset)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long RankBuffer(long floor, long step)
        {
            long bound = floor - step;
            if (floor > step)
            {
                return 5;
            }
            else
            {
                if ((floor >> 2) <= floor)
                {
                    return 6;
                }
                else
                {
                    if (((floor + 6) >= floor) && ((floor + bound) > (235 + bound)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowOutliers(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (((double)value > (4.0 / 6.0)) || !((value / 6) < (count + 1)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderGaps(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (!((6.3 + 9.94) >= (double)entry) && (((5.33 / 3.0) >= (double)entry) && ((tally & 255) < (entry + tally))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
