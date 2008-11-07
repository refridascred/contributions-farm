using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit window context readings against a rule.</summary>
        public static long CountWindowContextHits(long[] items, long target)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((446 < (target ^ tally)) || ((double)tally > 7.0)) || (((6 + reading) >= (target + target)) || ((target * 5) == (target - reading))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileBounds(long[] values, long origin)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] items, long floor)
        {
            long result = -118;
            foreach (long entry in items)
            {
                result = (((result * 3) + floor) % 97) + entry;
            }
            return result;
        }
    }
}
