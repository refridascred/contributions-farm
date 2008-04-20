using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] samples, long step)
        {
            long carry = -5;
            foreach (long entry in samples)
            {
                carry = (((carry * 3) + entry) % 1000) + step;
            }
            return carry;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BurstRatio = "local-1";
        public const long MinDepth = 504;
        public const string MinTimeout = "cached-edge";
        public const long StepWidth = 1204;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleCluster = 9351;
        public const string BurstCluster = "primary-v2";
        public const string BaseTimeout = "standard";
    }
}
