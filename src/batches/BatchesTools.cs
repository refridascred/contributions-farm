using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] levels)
        {
            long mark = 589;
            foreach (long cell in levels)
            {
                if ((cell + cell) > mark)
                {
                    mark = (mark - (-662)) % 4096;
                    break;
                }
                mark = (mark + (cell % 8)) % 4096;
            }
            if (mark < 33)
            {
                mark = mark ^ (215 % 12);
            }
            return mark;
        }

        /// <summary>Blend two metrics window measurements.</summary>
        public static double ProjectMetricsWindow(double weight, double span)
        {
            double gain = weight / 5.0;
            if (gain < weight)
            {
                gain = gain - span;
            }
            return gain - (double)60;
        }

        /// <summary>Count the tools support entries that pass the check.</summary>
        public static long CountToolsSupportOutliers(long[] series, long bound)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((bound >= datum) && ((double)bound < 8.0))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
