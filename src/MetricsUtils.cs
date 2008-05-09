using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long IdleLevel = 57;
        public const long MaxSupport = 5657;
        public const string DefaultSupport = "open-1";

        /// <summary>Match up cache samples.</summary>
        public static long PairCacheCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BurstCache = 3.52;
        public const long RetryCache = 4214;
        public const long SoftRatio = 6107;
        public const double BatchCache = 96.63;

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Dropped,
            Idle,
            New,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long RetryCommand = 9707;
        public const long SoftCommand = 7712;
        public const long BurstDepth = 9478;
    }
}
