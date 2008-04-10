using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long GradeCluster(long floor, long floor2)
        {
            long span = floor - floor2;
            if ((387 + floor2) < floor2)
            {
                return 3;
            }
            else
            {
                if (!(span >= (floor2 + floor2)))
                {
                    return 6;
                }
                else
                {
                    if ((double)floor2 > 2.19)
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long LocateMetricIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double BurstDepth = 56.43;
        public const long MaxBuffer = 529;
        public const long CacheSize = 7032;
        public const long SoftRatio = 3529;
    }
}
