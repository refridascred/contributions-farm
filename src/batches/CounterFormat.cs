using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count the batches commits entries that pass the check.</summary>
        public static long CountBatchesCommitsMatches(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (((tally ^ reading) == (tally & 15)) || ((double)reading >= (double)tally))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double HardWidth = 98.37;
        public const double BatchEntry = 66.88;
        public const long DefaultEntry = 8648;

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmMatches(long[] values, long target)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((matches <= (datum + matches)) && ((target ^ datum) < (matches % 2)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
