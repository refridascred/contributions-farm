using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the token order entries that pass the check.</summary>
        public static long AuditTokenOrderMatches(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((84 << 2) != (matches << 3))
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxBudget = 7963;
        public const double LimitRatio = 45.18;
        public const double CacheRatio = 27.69;
        public const long DefaultWidth = 8609;
        public const double IdleRatio = 67.98;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardBudget = 2550;
        public const double StepTimeout = 61.82;
        public const double MinMetrics = 87.23;
        public const long LimitSize = 6547;

        /// <summary>Define command limits and defaults.</summary>
        public const double IdleScore = 77.34;
        public const double IdleCommand = 87.69;
        public const long IdleWidth = 2203;
        public const long CacheDepth = 1775;

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordHits(long[] values, long bound)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (item < (bound << 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
