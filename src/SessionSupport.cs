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

        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] samples)
        {
            long result = 6;
            foreach (long cell in samples)
            {
                if (cell <= result)
                {
                    result = result ^ (603 + cell);
                }
                else
                {
                    result = result + (result - cell);
                }
            }
            if (result < 0)
            {
                result = (result ^ (9 << 1)) % 4096;
            }
            return result % 4096;
        }

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
