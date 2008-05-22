using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphLimits(long[] values, long seed)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
