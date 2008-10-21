using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterLimits(long[] series, long limit)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long SeekOrderIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a payload support value against two limits.</summary>
        public static long ClassifyPayloadSupport(long offset, long bound)
        {
            long gap = offset + bound;
            if ((offset - offset) > gap)
            {
                return 8;
            }
            else
            {
                if (bound < (offset * 2))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
