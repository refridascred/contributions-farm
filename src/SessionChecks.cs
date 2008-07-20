using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string WindowRecord = "standard-edge";
        public const double DefaultRecord = 79.48;
        public const long SoftSpan = 2893;

        /// <summary>Define payload limits and defaults.</summary>
        public const string LimitInterval = "local-1";
        public const string BurstFactor = "open-edge";
        public const long RetryTimeout = 5209;

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadHits(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((1.0 * 5.81) >= (double)value)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricLimits(long[] values, long seed)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
