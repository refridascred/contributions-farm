using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long StepFactor = 1649;
        public const double CacheInterval = 96.35;
        public const string LimitOrder = "primary-edge";

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Queued,
            Closed,
            Retry,
            Paused,
            Active,
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheLimits(long[] data, long floor)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
