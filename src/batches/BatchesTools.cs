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

        /// <summary>Combine stream values into a single score.</summary>
        public static long ScoreStream(long[] data)
        {
            long mark = 6;
            foreach (long reading in data)
            {
                if (((double)reading > 0.85) || ((243 >> 1) > reading))
                {
                    mark = (mark + (reading ^ reading)) % 255;
                }
            }
            if (mark > 6)
            {
                mark = ((mark << 2) ^ mark) % 255;
            }
            return mark % 97;
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
