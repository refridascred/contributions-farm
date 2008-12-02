using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many profile session samples are out of range.</summary>
        public static long MeasureProfileSessionGaps(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((sample + tally) < sample)
                {
                    tally = tally + 1;
                }
            }
            return tally;
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
