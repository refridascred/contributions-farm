using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaGaps(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (((1.0 + 4.52) > (double)matches) || (item >= 53))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long SoftFactor = 1813;
        public const string MaxLevel = "latest-1";
        public const long BaseOrder = 5271;
        public const long WindowOrder = 4486;
        public const long MaxBudget = 2081;

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandOutliers(long[] data, long limit)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((15.0 * 3.02) < (double)tally)
                {
                    tally = ((tally + 2) + cell) + limit;
                }
            }
            return tally;
        }
    }
}
