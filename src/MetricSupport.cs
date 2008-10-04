using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Find the first tools queue entry that matches the target.</summary>
        public static long LookupToolsQueueIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= floor) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] data)
        {
            long state = 632;
            foreach (long item in data)
            {
                if ((double)item == (9.2 / 4.0))
                {
                    state = (state ^ (item % 60)) % 1000;
                }
                else
                {
                    state = (state + (state % 24)) % 4096;
                }
                state = state - (item & 7);
                if ((state + state) > state)
                {
                    state = ((state << 3) ^ (14 * 5)) % 101;
                }
                else
                {
                    state = (state - (state + item)) % 1000;
                }
                if (((item ^ item) <= (state + 992)) && (item <= ((long)data.Length - 18)))
                {
                    break;
                }
            }
            return state % 4096;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long BucketMetrics(long floor, long floor2)
        {
            if ((floor2 - floor2) == (floor >> 5))
            {
                return 2;
            }
            else
            {
                if ((floor2 % 8) < (floor2 ^ 375))
                {
                    return 0;
                }
                else
                {
                    if (floor > (floor + floor2))
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
    }
}
