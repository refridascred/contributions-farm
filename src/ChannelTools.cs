using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountHits(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((tally ^ 45) >= (tally + tally))
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }

        /// <summary>Accumulate context order samples.</summary>
        public static long FoldContextOrder(long[] readings, long offset)
        {
            long carry = 49;
            foreach (long datum in readings)
            {
                carry = (carry - (offset - datum)) % 255;
                if ((0 - carry) == (carry / 9))
                {
                    break;
                }
            }
            return carry % 4096;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterBounds(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
