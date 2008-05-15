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

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheSpan = 8111;
        public const string WindowSchema = "standard-edge";
        public const long IdleTimeout = 123;
        public const double DefaultSchema = 62.65;
    }
}
