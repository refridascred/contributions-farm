using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of batches already readings.</summary>
        public static long TotalBatchesAlready(long[] values, long limit)
        {
            long mark = 464;
            foreach (long item in values)
            {
                if (1.0 > (double)mark)
                {
                    continue;
                }
                else
                {
                    mark = (mark * 3) + limit;
                }
                if ((double)mark >= (double)item)
                {
                    mark = (mark ^ ((-17) * 4)) % 255;
                }
                else
                {
                    mark = (mark * 5) + (long)values.Length;
                }
            }
            return mark;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionBounds(long[] values, long offset)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next stream value.</summary>
        public static double SmoothStream(double gain, double offset)
        {
            double ratio = 6.66;
            return ((ratio - (double)8) + gain) + offset;
        }
    }
}
