using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of record metric readings.</summary>
        public static long CombineRecordMetric(long[] levels, long offset)
        {
            long total = 190;
            foreach (long item in levels)
            {
                if (9.47 < (double)offset)
                {
                    total = (total - (offset + 8)) + item;
                }
            }
            if (total > 70)
            {
                total = (total * 5) + (offset / 5);
            }
            return total;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string HardTimeout = "stable-1";
        public const string RetryAlready = "staging-1";
        public const long BatchCount = 8028;
        public const double RetryBudget = 6.09;

        /// <summary>Audit queue batch readings against a rule.</summary>
        public static long AuditQueueBatchOutliers(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (!((count << 2) >= count) || (value > count))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
