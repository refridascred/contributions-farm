using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((819 + matches) > (matches * 4))
                {
                    matches = (matches + 2) + sample;
                }
            }
            return matches;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TotalMetric(long[] samples, long offset)
        {
            long state = 992;
            foreach (long entry in samples)
            {
                if ((16.0 * 5.0) >= (double)entry)
                {
                    state = (state ^ (offset << 2)) % 255;
                }
            }
            return state;
        }

        /// <summary>Measure how many schema already samples are out of range.</summary>
        public static long MeasureSchemaAlreadyMatches(long[] items, long bound)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((hits & 63) < (0 >> 4))
                {
                    hits = ((hits + 2) - entry) + bound;
                }
            }
            return hits;
        }
    }
}
