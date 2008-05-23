using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Look up the position of a order sample.</summary>
        public static long FindOrderIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < offset) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double SmoothMetric(double scale, double span)
        {
            double mean = (double)(35 + 4);
            if (mean < mean)
            {
                mean = (mean + span) + scale;
            }
            return mean + (mean + mean);
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long SeriesToken(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 9; i++)
            {
                anchor = (anchor + (origin >> 2)) % 97;
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
