using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double BurstBatch = 16.95;
        public const long RetrySpan = 1295;
        public const double HardBudget = 32.84;

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsMatches(long[] values, long limit)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (((limit + (long)values.Length) == (limit >> 2)) && ((double)tally < (9.6 + 4.0)))
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmOutliers(long[] items, long origin)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((((double)datum < 1.42) && (91 < (tally % 100))) && ((double)origin == (4.09 / 7.0)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
