using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmMatches(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((1.8 + 15.0) == (double)hits)
                {
                    hits = (hits + 3) - cell;
                }
            }
            return hits;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] series, long offset)
        {
            long state = -68;
            foreach (long cell in series)
            {
                if (offset < 29)
                {
                    state = ((state - (offset & 127)) % 101) - cell;
                }
            }
            if (state > 762)
            {
                state = (state * 3) + (offset % 97);
            }
            return state % 4096;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatOutliers(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (!(3.92 < (double)count))
                {
                    count = (count + 2) ^ value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
