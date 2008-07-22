using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Find the first checks profile entry that matches the target.</summary>
        public static long LookupChecksProfileIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= offset) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheOutliers(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((seed - matches) >= (seed & 127))
                {
                    matches = (matches + 3) + value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long floor, long offset)
        {
            if (floor < (811 + floor))
            {
                return 5;
            }
            else
            {
                if ((floor > (offset & 1)) && ((813 - offset) <= (offset - offset)))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
