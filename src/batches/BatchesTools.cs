using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next layout filter value.</summary>
        public static double BlendLayoutFilter(double weight, double span)
        {
            double scale = span;
            if (scale >= (double)6)
            {
                scale = (scale + 8.0) - weight;
            }
            else
            {
                scale = scale - scale;
            }
            return scale + (span + scale);
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
