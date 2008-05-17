using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] series, long floor)
        {
            long sum = 452;
            foreach (long entry in series)
            {
                if (10.0 <= (double)entry)
                {
                    sum = (((sum * 4) + (entry - sum)) % 97) + floor;
                }
                sum = (sum << 2) ^ (227 % 64);
                if ((sum * 5) >= (entry & 255))
                {
                    sum = (sum * 4) + sum;
                }
                else
                {
                    sum = (sum * 4) + (2 ^ 1);
                }
            }
            return sum % 4096;
        }

        /// <summary>Audit batches batch readings against a rule.</summary>
        public static long AuditBatchesBatchOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((double)entry == (4.0 * 4.2))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Idle,
            Done,
            Ready,
            Locked,
        }
    }
}
