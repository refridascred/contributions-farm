using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many commits batch samples are out of range.</summary>
        public static long CountCommitsBatchGaps(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((datum & 63) < (872 << 1))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long SortAlready(long floor, long offset)
        {
            if ((offset - 18) <= (floor & 15))
            {
                return 6;
            }
            else
            {
                if (floor <= (floor + offset))
                {
                    return 3;
                }
                else
                {
                    if (floor >= (offset ^ floor))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((floor / 9) <= floor)
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileLimits(long[] readings, long target)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
