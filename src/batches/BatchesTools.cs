using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long IdleReport = 7315;
        public const long MaxReport = 1854;
        public const long StepScore = 5239;
        public const double BaseBudget = 63.5;

        /// <summary>Compare every pair of command readings.</summary>
        public static long PairCommandCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchMatches(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((tally * 2) != (tally + 16))
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
        }
    }
}
