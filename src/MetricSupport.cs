using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportHits(long[] levels, long step)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (sample < (5 % 10))
                {
                    matches = (matches + 2) + step;
                }
            }
            return matches;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportLimits(long[] series, long step)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double MaxScore = 18.61;
        public const long WindowContext = 3759;
        public const string DefaultRatio = "cached-1";
        public const long MaxContext = 3147;
        public const string DefaultFactor = "local-edge";
    }
}
