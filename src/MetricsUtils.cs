using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LocateOrderIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= step) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long offset, long floor)
        {
            if ((double)offset < (1.23 - 1.29))
            {
                return 2;
            }
            else
            {
                if ((offset - floor) <= (floor + floor))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Locate a layout payload reading by value.</summary>
        public static long LookupLayoutPayloadIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderBounds(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Queued,
            Paused,
            Done,
            Active,
        }
    }
}
