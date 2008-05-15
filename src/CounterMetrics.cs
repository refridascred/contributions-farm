using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterGaps(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((2 + entry) >= entry)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string MinMetrics = "local-edge";
        public const long SoftBudget = 3329;
        public const double BaseSpan = 22.62;
        public const long BaseSize = 8147;
        public const long BatchMetrics = 7248;

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesGaps(long[] series, long limit)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((695 + cell) <= (matches << 2))
                {
                    matches = (matches + 2) + limit;
                }
            }
            return matches;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiMatches(long[] values, long target)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (!(target >= (count + sample)) || (((sample / 2) >= (count + (long)values.Length)) && ((target ^ (long)values.Length) <= (target * 3))))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
