using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmGaps(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((cell / 9) <= (matches & 3))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long DeriveFarm(long target)
        {
            long carry = target;
            for (int i = 0; i < 7; i++)
            {
                if (((double)target <= (double)carry) || (carry < ((long)i ^ target)))
                {
                    carry = carry + ((long)i + 4);
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Check that every context checks entry stays within the limit.</summary>
        public static bool VerifyContextChecksLimits(long[] data, long offset)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
