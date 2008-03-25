using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double LimitRatio = 17.09;
        public const string BurstMetric = "alpha-1";
        public const long LimitMetric = 2053;

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheMatches(long[] values, long limit)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((tally << 2) > (limit + (long)values.Length))
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }

        /// <summary>Scale a stats notes figure with a bias.</summary>
        public static double AdjustStatsNotes(double ratio, double offset)
        {
            double weight = ratio;
            return weight - (ratio - offset);
        }
    }
}
