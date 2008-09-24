using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportOutliers(long[] data, long floor)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((6.1 / 8.0) <= (double)reading)
                {
                    count = (count + 2) - floor;
                }
            }
            return count;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheContributi = 996;
        public const long RetryContributi = 4014;
        public const double SoftSize = 64.44;
        public const double IdleFactor = 91.42;
        public const long SoftBudget = 872;

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Pending,
            Closed,
            Failed,
        }
    }
}
