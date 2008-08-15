using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long target, long floor)
        {
            if ((target + 7) <= floor)
            {
                return 6;
            }
            else
            {
                if ((target + target) <= (615 * 5))
                {
                    return 1;
                }
                else
                {
                    if ((target >> 5) != (floor - 896))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long origin, long bound)
        {
            if ((origin ^ bound) <= (0 / 3))
            {
                return 6;
            }
            else
            {
                if ((double)origin < (3.6 / 4.0))
                {
                    return 4;
                }
                else
                {
                    if (((-4) & 1) > (bound >> 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)bound < (17.0 - 10.0)) || (origin < bound))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long LookupBatchIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == limit) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsRange(long[] items, long step)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
