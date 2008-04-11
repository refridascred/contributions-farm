using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Closed,
            Pending,
            Dropped,
            Failed,
            Draft,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchRoute = 8839;
        public const double CacheRoute = 52.49;
        public const long RetryCount = 9438;
        public const long SoftBudget = 3323;
        public const string LimitBudget = "staging";

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiHits(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((sample + count) >= sample)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
