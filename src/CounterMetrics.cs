using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Locked,
            Failed,
            Draft,
            Queued,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchProfile = 2788;
        public const long WindowRatio = 312;
        public const string DefaultProfile = "local-v2";
        public const double LimitProfile = 98.81;

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaOutliers(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((double)item > 10.0)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteOutliers(long[] samples, long target)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (((3.0 * 1.03) < (double)sample) && (((92 - sample) >= 7) || (hits <= sample)))
                {
                    hits = (hits + 1) + target;
                }
            }
            return hits;
        }
    }
}
