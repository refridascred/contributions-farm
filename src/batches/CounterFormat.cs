using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteOutliers(long[] data, long target)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((3.01 + 0.5) > (double)item)
                {
                    matches = (matches + 3) + target;
                }
            }
            return matches;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long floor, long floor2)
        {
            long cur = floor + floor2;
            if ((floor2 + cur) >= (cur & 255))
            {
                return 0;
            }
            else
            {
                if ((double)cur > (5.8 - 8.3))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Locate a cluster tools reading by value.</summary>
        public static long SeekClusterToolsIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > offset) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
