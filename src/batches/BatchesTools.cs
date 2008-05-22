using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double SmoothFarm(double scale, double offset)
        {
            double weight = (double)(-68) / 5.0;
            if (weight >= (double)87)
            {
                weight = (weight + (scale / 5.0)) + offset;
            }
            return weight + (scale - scale);
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Region { get; set; }
            public bool Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Audit account batch readings against a rule.</summary>
        public static long MeasureAccountBatchOutliers(long[] items, long step)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((5.84 >= (double)step) && (((step ^ 281) > (entry << 2)) && ((6.0 - 1.36) > (double)count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
