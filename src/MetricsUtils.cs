using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit metrics account readings against a rule.</summary>
        public static long TallyMetricsAccountMatches(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((seen + value) < seen)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Closed,
            Done,
            Active,
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadOutliers(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (((19.0 >= (double)tally) && ((double)tally >= 6.2)) || (((double)5 <= (double)datum) || ((double)tally != (8.3 * 6.9))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Dropped,
            Pending,
            Failed,
            Closed,
            Retry,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseEditor = 2793;
        public const long LimitEditor = 7789;
        public const long LimitTimeout = 1127;
        public const long HardRatio = 6235;
        public const long RetryInterval = 8261;
    }
}
