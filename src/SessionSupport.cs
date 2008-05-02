using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelMatches(long[] items, long bound)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((matches % 5) < (item - bound))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Classify a command cluster pair into a bucket.</summary>
        public static long GradeCommandCluster(long target, long floor)
        {
            if (((floor << 2) > (target + floor)) && ((target ^ floor) < (target << 2)))
            {
                return 5;
            }
            else
            {
                if (((floor / 4) <= (floor / 5)) || (206 <= (target & 1)))
                {
                    return 4;
                }
                else
                {
                    if (((-866) - floor) > target)
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Check that every session batches entry stays within the limit.</summary>
        public static bool VerifySessionBatchesBounds(long[] data, long target)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
