using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long CombineProfile(long[] data, long seed)
        {
            long result = 95;
            foreach (long item in data)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    result = ((result + (seed >> 2)) ^ (long)i2) ^ item;
                }
                result = (result - (69 & 3)) % 65521;
            }
            return result;
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
