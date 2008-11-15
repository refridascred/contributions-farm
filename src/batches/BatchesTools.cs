using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long MinEditor = 6972;
        public const long RetryRatio = 6102;
        public const long DefaultEditor = 8140;

        /// <summary>Locate a route reading by value.</summary>
        public static long LocateRouteIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= seed) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank profile layout input into a small class.</summary>
        public static long BucketProfileLayout(long target, long target2)
        {
            long slot = target ^ target2;
            if ((1 << 3) < (target2 + target))
            {
                return 1;
            }
            else
            {
                if ((slot >> 4) != (target2 ^ target2))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
