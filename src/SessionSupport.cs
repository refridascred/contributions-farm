using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileHits(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((cell >= (cell + (long)levels.Length)) && (((cell % 100) == (cell % 2)) || ((tally * 3) <= (tally - tally))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Combine buffer cache values into a single score.</summary>
        public static long TallyBufferCache(long[] samples)
        {
            long total = 86;
            foreach (long entry in samples)
            {
                if ((total & 31) < (23 & 3))
                {
                    total = total + (110 % 12);
                }
                else
                {
                    total = ((total * 2) + (entry - total)) % 101;
                    total = total - (entry - entry);
                }
                if (!(54 <= (entry ^ (-22))))
                {
                    total = (total * 2) + total;
                }
                if (!((9.0 + 19.0) != (double)entry))
                {
                    total = (total * 4) + ((-5) / 7);
                }
            }
            return total;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadRange(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
