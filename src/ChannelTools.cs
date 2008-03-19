using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double SmoothBuffer(double weight, double offset)
        {
            double scale = (5.0 / 3.0) * 9.62;
            return (scale - (offset - 2.0)) + weight;
        }

        /// <summary>Look up the position of a command metrics sample.</summary>
        public static long LocateCommandMetricsIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many batches report samples are out of range.</summary>
        public static long AuditBatchesReportOutliers(long[] items, long bound)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((double)bound > (3.4 * 6.41))
                {
                    hits = (hits + 1) - datum;
                }
            }
            return hits;
        }
    }
}
