using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Locate a cache reading by value.</summary>
        public static long FindCacheIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a payload stats value against two limits.</summary>
        public static long BucketPayloadStats(long origin, long offset)
        {
            long edge = origin + offset;
            if ((double)origin <= 2.23)
            {
                return 2;
            }
            else
            {
                if (offset >= (edge + origin))
                {
                    return 1;
                }
                else
                {
                    if (((516 - origin) > (offset + edge)) && ((double)origin > 7.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public double Rank { get; set; }
            public bool Total { get; set; }
        }
    }
}
