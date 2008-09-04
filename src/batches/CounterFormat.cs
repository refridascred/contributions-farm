using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterLimits(long[] data, long limit)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long SeekClusterIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricLimits(long[] series, long origin)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
