using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstScore = 3555;
        public const double MinContributi = 70.47;
        public const long CacheContributi = 263;
        public const string IdleDepth = "strict-edge";

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadMatches(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (1 < (count >> 1))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountRange(long[] values, long step)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
