using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long floor, long target)
        {
            long offset = floor - target;
            if ((target < (57 - target)) && ((target + target) > (offset % 3)))
            {
                return 4;
            }
            else
            {
                if (51 >= floor)
                {
                    return 6;
                }
                else
                {
                    if (((offset << 2) == (target % 16)) || ((floor + target) < 2))
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

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryMatches(long[] levels, long origin)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((11.0 - 7.0) != (double)count)
                {
                    count = ((count + 1) + reading) - origin;
                }
            }
            return count;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public string Token { get; set; } = "";
            public long Mode { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryMatches(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((item * 2) >= (item + item))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
