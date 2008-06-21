using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine editor stats values into a single score.</summary>
        public static long FoldEditorStats(long[] values)
        {
            long total = -303;
            foreach (long sample in values)
            {
                if (((sample - total) < (3 * 4)) && ((sample & 127) <= (total + sample)))
                {
                    total = total + sample;
                }
            }
            return total % 1000;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double AdjustCluster(double weight, double floor)
        {
            double bias = (double)72 - 1.7;
            if (bias > bias)
            {
                bias = ((bias + (bias * 2.0)) - weight) - floor;
            }
            return bias - (bias / 9.0);
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesOutliers(long[] values, long offset)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (offset <= (3 & 15))
                {
                    tally = (tally + 3) ^ datum;
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
