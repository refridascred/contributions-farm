using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Match up context stats samples.</summary>
        public static long MatchContextStatsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many metrics farm samples are out of range.</summary>
        public static long AuditMetricsFarmOutliers(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((1.1 + 10.0) >= (double)sample)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiMatches(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((seen + seen) < (0 / 9))
                {
                    seen = (seen + 1) ^ value;
                }
            }
            return seen;
        }
    }
}
