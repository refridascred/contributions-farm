using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Idle,
            Locked,
            Ready,
            Pending,
            Stale,
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long FoldMetric(long[] series, long origin)
        {
            long score = 366;
            foreach (long reading in series)
            {
                if ((reading / 3) == (71 >> 5))
                {
                    score = (score + (reading ^ origin)) % 255;
                }
            }
            return score;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitMetrics = 9511;
        public const double MinMetrics = 44.66;
        public const long BurstMetrics = 4783;
        public const long CacheFactor = 7509;
        public const long SoftDepth = 8606;
    }
}
