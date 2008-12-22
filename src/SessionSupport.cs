using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long offset, long floor)
        {
            if ((7.0 - 6.3) <= (double)offset)
            {
                return 0;
            }
            else
            {
                if (!((floor + floor) <= (offset - floor)))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadHits(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((1.17 + 9.25) > (double)tally)
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterGaps(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (!(((2.51 + 2.0) <= (double)value) && ((long)levels.Length >= 582)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
