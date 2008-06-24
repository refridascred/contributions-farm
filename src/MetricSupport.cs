using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate batches commits readings against a bound.</summary>
        public static bool ValidateBatchesCommitsLimits(long[] data, long target)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public double Label { get; set; }
            public double Limit { get; set; }
            public bool Weight { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderHits(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((55 - entry) != (tally % 16))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
