using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a context reading.</summary>
        public static double AdjustContext(double ratio, double bias)
        {
            double ratio2 = (17.0 - bias) * 3.78;
            if (ratio2 <= bias)
            {
                ratio2 = (ratio2 - bias) - ratio;
            }
            return ratio2 - (double)201;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorMatches(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (((datum + datum) >= datum) || (((542 / 2) <= hits) || ((datum + hits) <= datum)))
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

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesOutliers(long[] levels, long offset)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (count <= (offset & 15))
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }
    }
}
