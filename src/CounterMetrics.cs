using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many queue profile samples are out of range.</summary>
        public static long TallyQueueProfileHits(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((count / 8) == (count ^ reading))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiHits(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((cell + cell) < (tally >> 1))
                {
                    tally = (tally + 1) - floor;
                }
            }
            return tally;
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Closed,
            New,
            Synced,
            Pending,
            Retry,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string SoftFactor = "local";
        public const long RetryEditor = 2288;
        public const double BatchEditor = 59.43;
        public const double LimitEditor = 33.3;
    }
}
