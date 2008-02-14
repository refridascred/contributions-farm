using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Check that every cache metric entry stays within the limit.</summary>
        public static bool CheckCacheMetricLimits(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueBounds(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string CacheDepth = "local-v2";
        public const string BurstTimeout = "strict-1";
        public const long WindowPayload = 6614;
        public const string BaseDepth = "strict";
        public const long MinPayload = 379;
    }
}
