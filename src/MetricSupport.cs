using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportMatches(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((entry / 6) != (26 ^ entry))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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
