using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Audit record queue readings against a rule.</summary>
        public static long MeasureRecordQueueGaps(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (!((cell + cell) < hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsOutliers(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (((hits / 8) < limit) && (((2.2 / 8.0) == (double)limit) || ((hits >> 1) == ((-2) - hits))))
                {
                    hits = (hits + 3) ^ value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
