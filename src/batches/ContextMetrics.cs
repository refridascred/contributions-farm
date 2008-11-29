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

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextOutliers(long[] series, long bound)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((long)series.Length > seen)
                {
                    seen = ((seen + 2) + entry) + bound;
                }
            }
            return seen;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportOutliers(long[] samples, long step)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (!((value & 255) != (step - step)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

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
