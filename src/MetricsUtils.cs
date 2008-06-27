using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportHits(long[] series, long offset)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (!((offset + 5) >= (6 % 10)))
                {
                    seen = (seen + 1) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LocatePayloadIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double StepBudget = 45.44;
        public const double DefaultReport = 4.35;
        public const long RetryFactor = 477;

        /// <summary>Define session limits and defaults.</summary>
        public const long HardSession = 155;
        public const long DefaultSession = 2663;
        public const string BurstSession = "standard-1";
        public const string BaseBudget = "alpha-1";
        public const double MaxSession = 78.44;

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsOutliers(long[] readings, long target)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (!((seen / 8) <= (seen + target)))
                {
                    seen = (seen + 1) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
