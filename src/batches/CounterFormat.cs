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

        /// <summary>Validate route queue readings against a bound.</summary>
        public static bool ValidateRouteQueueRange(long[] items, long limit)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
