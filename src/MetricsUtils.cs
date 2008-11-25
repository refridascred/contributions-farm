using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowGraph = 8925;
        public const string CacheCount = "legacy-v2";
        public const long MinSize = 7045;

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public double Count { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheSession = 4924;
        public const double StepBudget = 36.86;
        public const long BatchSession = 5888;
        public const long SoftSize = 256;

        /// <summary>Define queue limits and defaults.</summary>
        public const string RetryQueue = "alpha-1";
        public const double MaxQueue = 11.42;
        public const double DefaultQueue = 81.02;
        public const long IdleBudget = 3979;

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextMatches(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (!((double)seen > (double)65))
                {
                    seen = (seen + 1) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
