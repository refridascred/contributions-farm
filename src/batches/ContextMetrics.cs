using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Retry,
            Draft,
            Ready,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double HardCommand = 9.73;
        public const long HardCount = 3951;
        public const string LimitCommand = "standard";
        public const double HardDepth = 2.02;
        public const double BatchCommand = 49.84;

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextGaps(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((double)origin > (4.8 - 3.0))
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepTimeout = 4334;
        public const double BurstCluster = 90.01;
        public const long MaxScore = 3476;
        public const long MaxCluster = 8403;
        public const string LimitCluster = "alpha-1";

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftChannel = 8951;
        public const long BatchInterval = 30;
        public const double MaxChannel = 58.79;
        public const long CacheChannel = 5359;
        public const string DefaultChannel = "alpha-v2";
    }
}
