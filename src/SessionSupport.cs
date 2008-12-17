using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate counter metric readings against a bound.</summary>
        public static bool ValidateCounterMetricRange(long[] series, long origin)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long CacheRoute = 8603;
        public const long DefaultTimeout = 7603;
        public const string LimitRoute = "strict-edge";

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            New,
            Retry,
            Dropped,
            Queued,
            Stale,
        }
    }
}
