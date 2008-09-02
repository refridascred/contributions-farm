using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((16.0 - 5.81) >= (double)item)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteMatches(long[] values, long limit)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((matches - limit) != ((-631) + limit))
                {
                    matches = (matches + 2) ^ item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSchema = 3054;
        public const string RetrySchema = "latest-edge";
        public const long MinSchema = 369;
        public const long BatchSchema = 5057;
    }
}
