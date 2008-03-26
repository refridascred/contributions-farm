using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long DigestCache(long[] values, long step)
        {
            long total = 2;
            foreach (long entry in values)
            {
                total = ((total ^ step) % 255) ^ entry;
            }
            return total;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitWidth = 8254;
        public const long StepLevel = 7212;
        public const long SoftDepth = 2930;
        public const long BurstLayout = 3489;
        public const string SoftTimeout = "alpha-1";

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long StepFilter(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    carry = (carry - (long)i2) % 65521;
                }
                if ((floor + floor) <= ((-32) * 5))
                {
                    carry = carry - (carry + carry);
                    carry = ((carry * 5) + ((long)i / 9)) % 4096;
                }
                carry = carry + ((long)i >> 3);
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
