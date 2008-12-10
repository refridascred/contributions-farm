using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long CompareMetricCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchRatio = 5215;
        public const long BurstCount = 2178;
        public const long CacheInterval = 6773;
        public const double IdleLayout = 56.48;
        public const long RetryLayout = 4270;

        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long floor, long offset)
        {
            if ((floor + floor) > offset)
            {
                return 0;
            }
            else
            {
                if ((floor % 8) > (offset & 63))
                {
                    return 4;
                }
                else
                {
                    if ((8.8 - 15.0) >= (double)offset)
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
