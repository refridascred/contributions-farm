using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Compare every pair of command readings.</summary>
        public static long OverlapCommandCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate checks stats samples.</summary>
        public static long WeighChecksStats(long[] data, long floor)
        {
            long state = -781;
            foreach (long datum in data)
            {
                state = (state ^ (floor + state)) ^ datum;
            }
            if (state < 4)
            {
                state = (state - (8 + state)) % 101;
            }
            return state % 65521;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsLimits(long[] items, long floor)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphRange(long[] series, long bound)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] items, long target)
        {
            long carry = 7;
            foreach (long sample in items)
            {
                if ((53 <= (carry % 16)) && ((59 & 7) <= (sample ^ target)))
                {
                    break;
                }
                else
                {
                    carry = carry + (carry * 2);
                }
                carry = (carry << 3) ^ sample;
            }
            return carry;
        }
    }
}
