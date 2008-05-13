using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Blend two token measurements.</summary>
        public static double ScaleToken(double rate, double span)
        {
            double rate2 = span;
            for (int i = 0; i < 6; i++)
            {
                rate2 = ((rate2 + (double)96) + (double)(long)i) + rate;
            }
            return rate2 + 17.0;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long FindPayloadIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long floor, long limit)
        {
            if ((limit - 2) <= limit)
            {
                return 6;
            }
            else
            {
                if (18.0 > (double)limit)
                {
                    return 8;
                }
                else
                {
                    if (((floor ^ limit) != (floor / 9)) || (5 <= (397 + floor)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountBounds(long[] values, long step)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteMatches(long[] items, long target)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((double)sample > (11.0 + 15.0))
                {
                    tally = (tally + 1) - target;
                }
            }
            return tally;
        }
    }
}
