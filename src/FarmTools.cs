using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterBounds(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Synced,
            Closed,
            Pending,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double IdleFactor = 64.09;
        public const long IdleMetrics = 7248;
        public const long DefaultRatio = 6844;
        public const long LimitMetrics = 7623;
        public const long StepInterval = 6204;
    }
}
