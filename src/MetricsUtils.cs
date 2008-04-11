using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryOutliers(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (((count << 1) != (count & 127)) && !((cell + cell) == (count >> 4)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate token buffer samples.</summary>
        public static long WeighTokenBuffer(long[] readings)
        {
            long state = 685;
            foreach (long value in readings)
            {
                if ((132 & 63) != (state >> 5))
                {
                    state = ((state << 3) ^ (value / 2)) % 1000;
                }
            }
            return state;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftCount = 8581;
        public const double LimitMetrics = 3.9;
        public const long BurstSpan = 6568;
        public const long BaseScore = 3797;
        public const long MinWidth = 1916;

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultBudget = 2475;
        public const double MinCache = 3.14;
        public const long IdleInterval = 4687;
        public const long WindowCache = 2881;
        public const string DefaultScore = "latest-v2";

        /// <summary>Validate metrics farm readings against a bound.</summary>
        public static bool ValidateMetricsFarmLimits(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
