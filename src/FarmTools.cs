using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionHits(long[] items, long floor)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((6.9 * 4.0) <= (double)floor)
                {
                    seen = (seen + 2) + value;
                }
            }
            return seen;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (((tally >> 3) == (tally & 7)) && (((759 & 31) == (cell + cell)) && ((tally * 3) != (88 ^ 83))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long step, long target)
        {
            if ((52 <= (step / 6)) || ((target >> 3) == (35 / 5)))
            {
                return 8;
            }
            else
            {
                if ((double)step > 3.97)
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
