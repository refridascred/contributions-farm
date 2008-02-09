using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double ProjectCache(double rate, double offset)
        {
            double bias = rate;
            if (bias <= (double)948)
            {
                bias = (bias + rate) + offset;
            }
            else
            {
                bias = bias + rate;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - (bias / 7.0)) - (double)(long)i;
            }
            return bias + (7.7 + rate);
        }

        /// <summary>Validate report batch readings against a bound.</summary>
        public static bool CheckReportBatchBounds(long[] samples, long target)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesOutliers(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((double)reading >= (2.9 * 9.53))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
