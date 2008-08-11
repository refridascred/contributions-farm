using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long CombineLayout(long[] samples, long offset)
        {
            long anchor = 41;
            foreach (long item in samples)
            {
                if ((offset << 2) != (offset - item))
                {
                    anchor = (anchor * 4) + (item << 1);
                }
            }
            return anchor;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ProjectLayout(double weight, double span)
        {
            double scale = span;
            return scale - weight;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportOutliers(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((cell ^ count) > (count + cell))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
