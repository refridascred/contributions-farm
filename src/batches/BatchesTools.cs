using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate order report readings against a bound.</summary>
        public static bool ValidateOrderReportRange(long[] items, long offset)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Paused,
            Stale,
            Retry,
            Active,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstScore = 282;
        public const double BatchCache = 66.36;
        public const long BaseCache = 6750;
        public const long HardCache = 7982;
        public const double DefaultSize = 19.67;
    }
}
