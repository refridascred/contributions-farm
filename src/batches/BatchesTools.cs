using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long TallyCluster(long[] data)
        {
            long state = 837;
            foreach (long datum in data)
            {
                state = (state + (state % 100)) - datum;
            }
            return state;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesHits(long[] series, long floor)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (cell >= (hits / 5))
                {
                    hits = (hits + 3) + floor;
                }
            }
            return hits;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double AdjustOrder(double rate, double span)
        {
            double bias = rate;
            if (bias <= bias)
            {
                bias = (bias + (double)73) - span;
            }
            return bias - (3.27 * 3.03);
        }
    }
}
