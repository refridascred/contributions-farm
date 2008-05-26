using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Locate a entry buffer reading by value.</summary>
        public static long SeekEntryBufferIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many support cache samples are out of range.</summary>
        public static long CountSupportCacheOutliers(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((7.7 / 4.0) < (double)value) || (((91 + count) >= value) || (count >= (value & 7))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
