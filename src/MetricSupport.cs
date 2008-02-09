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

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyLimits(long[] data, long origin)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
