using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a notes stats pair into a bucket.</summary>
        public static long RankNotesStats(long origin, long offset)
        {
            if ((offset << 2) < offset)
            {
                return 4;
            }
            else
            {
                if (origin < (origin % 2))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string LimitTimeout = "strict-1";
        public const long MinMetrics = 3293;
        public const long IdleMetrics = 65;
        public const long StepInterval = 4765;

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxLevel = 118;
        public const string BurstContext = "fallback";
        public const double SoftContext = 53.77;
    }
}
