using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long TallyFormat(long[] series)
        {
            long state = -2;
            foreach (long item in series)
            {
                if ((item + state) != (item + 183))
                {
                    state = state ^ state;
                }
                else
                {
                    state = ((state * 5) + (385 & 3)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaOutliers(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((double)seed <= 15.0)
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long WindowBudget = 2829;
        public const long RetryInterval = 653;
        public const long MinCommand = 5587;
        public const long StepSpan = 5345;
    }
}
