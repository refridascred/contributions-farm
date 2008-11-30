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

        /// <summary>Iterate the already support series from a seed.</summary>
        public static long DeriveAlreadySupport(long target)
        {
            long total = target;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }
    }
}
