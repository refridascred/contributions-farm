using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long SeriesContributi(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 12; i++)
            {
                sum = (sum * 2) + (sum ^ floor);
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
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
