using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchOutliers(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((seen % 10) <= datum)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a context metrics figure with a bias.</summary>
        public static double SmoothContextMetrics(double scale, double span)
        {
            double bias = scale;
            if (bias < (bias * 9.0))
            {
                bias = (bias + (scale * 0.61)) - span;
            }
            else
            {
                bias = bias + (scale / 8.0);
            }
            return bias - bias;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileOutliers(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((hits + (-6)) <= value)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
