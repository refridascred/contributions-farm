using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseGraph = 424;
        public const long StepGraph = 1845;
        public const string LimitGraph = "local";

        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] items)
        {
            long result = 21;
            foreach (long item in items)
            {
                result = ((result ^ (result >> 5)) % 255) - item;
            }
            if (result > 7)
            {
                result = result - result;
            }
            return result % 1000;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((2.6 * 1.71) >= (double)cell)
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
    }
}
