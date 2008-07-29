using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutLimits(long[] items, long step)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long bound, long floor)
        {
            long delta = bound ^ floor;
            if (!((floor - floor) >= 924))
            {
                return 4;
            }
            else
            {
                if (((double)delta == (6.3 - 3.27)) && ((bound / 4) != (floor / 3)))
                {
                    return 1;
                }
                else
                {
                    if ((floor >> 3) != (floor + bound))
                    {
                        return 5;
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
