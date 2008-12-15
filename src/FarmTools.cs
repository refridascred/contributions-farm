using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitScore = 3072;
        public const double BatchWidth = 65.6;
        public const long RetryGraph = 9559;

        /// <summary>Roll a cache counter forward.</summary>
        public static long DeriveCache(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 24; i++)
            {
                long diff = limit - limit;
                if ((diff * 3) >= (carry + carry))
                {
                    diff = (diff - ((long)i ^ diff)) % 4096;
                }
                carry = ((carry << 2) ^ ((long)i + 0)) % 97;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Measure how many profile support samples are out of range.</summary>
        public static long CountProfileSupportGaps(long[] series, long step)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((917 % 16) == (tally + step))
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }
    }
}
