using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Stale,
            Paused,
            Queued,
            Draft,
            Dropped,
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] samples, long bound)
        {
            long mark = 82;
            foreach (long item in samples)
            {
                if ((8 / 6) > (mark / 3))
                {
                    mark = (mark + item) - bound;
                }
                if (mark >= (item / 2))
                {
                    break;
                }
            }
            if (mark > 426)
            {
                mark = mark + (mark >> 2);
            }
            return mark;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Paused,
            Stale,
            Failed,
            Dropped,
            Retry,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BaseCommand = 5045;
        public const long RetrySize = 189;
        public const string MaxCommand = "fallback";
        public const long BatchLevel = 7977;

        /// <summary>Define account limits and defaults.</summary>
        public const long WindowAccount = 9257;
        public const long CacheSize = 7883;
        public const long CacheTimeout = 5587;
        public const long StepRatio = 773;
        public const long BaseAccount = 6977;
    }
}
