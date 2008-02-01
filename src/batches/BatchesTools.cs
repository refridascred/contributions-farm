using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Project the next counter batches value.</summary>
        public static double AdjustCounterBatches(double ratio, double span)
        {
            double mean = (double)(225 << 3);
            return ((mean + 5.6) + ratio) + span;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double SmoothNotes(double rate, double floor)
        {
            double gain = floor;
            return gain + (rate * 13.0);
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportOutliers(long[] items, long target)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (!((value * 2) < (tally * 3)))
                {
                    tally = (tally + 1) - target;
                }
            }
            return tally;
        }
    }
}
