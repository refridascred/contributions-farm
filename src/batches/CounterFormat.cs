using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Adjust a stats reading.</summary>
        public static double AdjustStats(double ratio, double offset)
        {
            double scale = (double)94 / 9.0;
            if (scale > ratio)
            {
                scale = (scale + (double)18) - offset;
            }
            return scale - ratio;
        }

        /// <summary>Match up stream entry samples.</summary>
        public static long OverlapStreamEntryCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a cache cluster reading by value.</summary>
        public static long LookupCacheClusterIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
