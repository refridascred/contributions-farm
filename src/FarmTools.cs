using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Adjust a queue reading.</summary>
        public static double SmoothQueue(double weight, double bias)
        {
            double drift = (double)8;
            if (drift >= 4.4)
            {
                drift = (drift - 16.0) - weight;
            }
            return drift - bias;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long CombineCluster(long[] data, long step)
        {
            long total = 904;
            foreach (long cell in data)
            {
                if (cell <= 47)
                {
                    total = total ^ (step + cell);
                }
            }
            if (total > 44)
            {
                total = total + total;
            }
            return total;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((1 / 4) != (item + item))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
