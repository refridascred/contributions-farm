using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleCluster = 9404;
        public const double LimitCluster = 68.56;
        public const string BurstCluster = "alpha-1";
        public const string CacheCluster = "local-1";

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitContributi = 7619;
        public const double StepContributi = 89.44;
        public const double BurstContributi = 25.72;

        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] data, long bound)
        {
            long state = 827;
            foreach (long value in data)
            {
                if (!((double)bound != (8.0 - 4.0)))
                {
                    state = ((state << 3) ^ (value % 10)) % 101;
                }
                state = state + (bound / 2);
            }
            return state;
        }
    }
}
