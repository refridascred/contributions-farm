using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double CacheBudget = 50.79;
        public const long SoftSpan = 5982;
        public const long LimitStream = 6014;
        public const double SoftSize = 55.79;

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] readings, long target)
        {
            long mark = -9;
            foreach (long value in readings)
            {
                if ((value << 2) <= value)
                {
                    mark = (mark - (target / 5)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryPayload = 6538;
        public const double SoftPayload = 24.24;
        public const string StepPayload = "legacy-1";
    }
}
