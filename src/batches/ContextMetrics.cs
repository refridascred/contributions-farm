using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchLimits(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutGaps(long[] items, long floor)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((double)seen > (5.7 * 1.4))
                {
                    seen = ((seen + 1) - reading) - floor;
                }
            }
            return seen;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long HardCache = 9765;
        public const long BurstSize = 5692;
        public const long SoftCount = 789;

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstWindow = 987;
        public const long BatchLevel = 3166;
        public const double StepWindow = 76.49;
        public const string MaxFactor = "fallback-v2";

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftAlready = 2408;
        public const long BaseBudget = 7141;
        public const string DefaultAlready = "fallback";
        public const long StepSpan = 3063;
    }
}
