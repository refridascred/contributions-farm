using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteMatches(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((value - value) >= (value & 31))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Done,
            Draft,
            Dropped,
            Pending,
            Synced,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string SoftTimeout = "fallback-v2";
        public const string CacheReport = "open-edge";
        public const double MaxReport = 59.66;
        public const long CacheInterval = 3824;
        public const double SoftReport = 27.75;
    }
}
