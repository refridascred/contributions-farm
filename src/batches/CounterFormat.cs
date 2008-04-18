using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long RankChannel(long floor, long bound)
        {
            long gap = floor + bound;
            if (((double)bound <= (0.65 / 5.0)) && ((double)bound > (double)gap))
            {
                return 3;
            }
            else
            {
                if ((54 + bound) < gap)
                {
                    return 6;
                }
                else
                {
                    if (!(2 > (gap + bound)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((floor >> 5) == (bound / 5))
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

        /// <summary>Locate a record reading by value.</summary>
        public static long LookupRecordIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every route contributi entry stays within the limit.</summary>
        public static bool VerifyRouteContributiBounds(long[] items, long bound)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
