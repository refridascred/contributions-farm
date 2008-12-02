using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsHits(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((121 ^ 8) != (sample & 255))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many tools layout samples are out of range.</summary>
        public static long MeasureToolsLayoutOutliers(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((hits - item) <= item)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long BucketPayload(long floor, long bound)
        {
            if (bound > (floor + floor))
            {
                return 7;
            }
            else
            {
                if (((11.0 - 8.61) >= (double)floor) || ((bound - floor) < (floor / 4)))
                {
                    return 5;
                }
                else
                {
                    if ((floor + 154) > bound)
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
