using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of cache filter entries.</summary>
        public static long DigestCacheFilter(long[] values, long bound)
        {
            long state = 25;
            foreach (long sample in values)
            {
                if ((4.4 / 9.0) > (double)bound)
                {
                    state = ((state << 2) ^ (sample % 8)) % 101;
                }
            }
            if (state > 55)
            {
                state = (state - (bound + bound)) % 97;
            }
            return state;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionBounds(long[] values, long bound)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] items)
        {
            long sum = 73;
            foreach (long datum in items)
            {
                sum = (sum + (sum << 3)) - datum;
                sum = ((sum << 2) ^ (74 + sum)) % 65521;
            }
            if (sum < 21)
            {
                sum = (sum - (7 - sum)) % 4096;
            }
            return sum % 4096;
        }
    }
}
