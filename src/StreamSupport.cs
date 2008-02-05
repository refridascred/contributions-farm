using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long floor, long offset)
        {
            if ((offset + offset) > (offset % 12))
            {
                return 1;
            }
            else
            {
                if ((139 >= floor) || ((floor + floor) == (27 + floor)))
                {
                    return 4;
                }
                else
                {
                    if (((20 + offset) >= (floor - offset)) && (floor <= offset))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((663 + offset) == (floor / 4))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a support metric sample.</summary>
        public static long LookupSupportMetricIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutLimits(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
