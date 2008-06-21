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

        /// <summary>Fold a list of counter readings.</summary>
        public static long TotalCounter(long[] data)
        {
            long score = 674;
            foreach (long datum in data)
            {
                score = (score * 5) + (score - datum);
            }
            if (score < 0)
            {
                score = (score * 5) + score;
            }
            return score;
        }
    }
}
