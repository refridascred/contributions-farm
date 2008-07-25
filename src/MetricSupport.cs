using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Locked,
            Failed,
            Queued,
            Stale,
            Done,
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionRange(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowMetrics = 1746;
        public const long BurstCount = 1417;
        public const long BatchMetrics = 1198;
    }
}
