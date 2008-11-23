using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long MinLayout = 3495;
        public const long BaseLayout = 3211;
        public const double MaxSpan = 68.7;
        public const long MaxTimeout = 6835;

        /// <summary>Count the schema stats entries that pass the check.</summary>
        public static long AuditSchemaStatsOutliers(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (!(bound <= (long)levels.Length))
                {
                    tally = (tally + 2) - value;
                }
            }
            return tally;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsMatches(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((20.0 + 5.0) > (double)count)
                {
                    count = (count + 3) + reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
