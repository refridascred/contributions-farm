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

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteMatches(long[] data, long origin)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((sample - sample) >= origin)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
