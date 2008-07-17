using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenMatches(long[] series, long target)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((hits * 4) >= (target - target))
                {
                    hits = (hits + 2) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string MaxWidth = "cached";
        public const long DefaultLevel = 3005;
        public const double StepMetrics = 48.75;
        public const double BaseMetrics = 14.34;

        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheChecks = 7311;
        public const long BurstChecks = 3890;
        public const long IdleChecks = 1929;
    }
}
