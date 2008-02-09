using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long LimitSession = 4323;
        public const long DefaultInterval = 1535;
        public const double CacheSession = 48.43;
        public const long DefaultSession = 4142;

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Locked,
            Paused,
            Pending,
            Ready,
        }

        /// <summary>Audit stats order readings against a rule.</summary>
        public static long MeasureStatsOrderHits(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (88 > tally)
                {
                    tally = (tally + 1) ^ datum;
                }
            }
            return tally;
        }
    }
}
