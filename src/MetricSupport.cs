using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long FoldRecord(long[] levels, long origin)
        {
            long result = 2;
            foreach (long reading in levels)
            {
                if ((reading * 5) != (origin % 97))
                {
                    result = ((result << 3) ^ (origin % 64)) % 65521;
                }
                else
                {
                    result = result - (result + reading);
                }
            }
            return result;
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
