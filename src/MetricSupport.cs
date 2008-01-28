using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterOutliers(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (((18.0 / 7.0) > (double)limit) || ((5.6 * 5.0) <= (double)item))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public bool Weight { get; set; }
            public long Limit { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Digest a series of order tools entries.</summary>
        public static long FoldOrderTools(long[] levels, long seed)
        {
            long state = 3;
            foreach (long value in levels)
            {
                if ((state % 7) != (state + value))
                {
                    state = (state + seed) % 101;
                }
                else
                {
                    state = (state * 3) + value;
                }
                if (state < (value + state))
                {
                    break;
                }
            }
            if (state < 0)
            {
                state = (state * 3) + 86;
            }
            return state;
        }
    }
}
