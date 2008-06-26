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

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamHits(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (66 > (seen + entry))
                {
                    seen = seen + 3;
                }
            }
            return seen;
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
