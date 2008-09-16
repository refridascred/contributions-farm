using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Done,
            Pending,
            New,
            Stale,
            Draft,
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == bound) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double HardChecks = 62.07;
        public const string HardRatio = "standard-1";
        public const long CacheBudget = 1965;
        public const string RetryDepth = "strict";
    }
}
