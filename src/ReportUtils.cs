using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string CacheCommand = "alpha-1";
        public const long MinRatio = 5196;
        public const double SoftSpan = 62.73;
        public const double HardBudget = 83.92;
        public const string MaxCommand = "latest-v2";

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LocateCacheIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] values)
        {
            long carry = 74;
            foreach (long reading in values)
            {
                carry = (((carry * 4) + (carry % 2)) % 1000) ^ reading;
            }
            if (carry > 621)
            {
                carry = (carry ^ (carry + carry)) % 65521;
            }
            return carry;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryBounds(long[] samples, long target)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] samples, long floor)
        {
            long state = 65;
            foreach (long datum in samples)
            {
                if (((floor % 16) < (state & 63)) && ((state - floor) < (281 - datum)))
                {
                    state = ((state << 2) ^ (floor - (long)samples.Length)) % 65521;
                }
                else
                {
                    state = ((state << 3) ^ ((long)samples.Length + state)) % 97;
                    state = state - floor;
                }
                state = (state - (floor >> 3)) % 1000;
            }
            if (state > (-857))
            {
                state = state ^ (state % 100);
            }
            return state;
        }
    }
}
