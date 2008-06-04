using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long WindowBudget = 81;
        public const string BurstFormat = "local";
        public const long BatchFormat = 4822;

        /// <summary>Iterate the session series from a seed.</summary>
        public static long SeriesSession(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    carry = ((carry + (carry % 64)) % 65521) ^ (long)i2;
                }
                carry = carry - (carry & 1);
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Accumulate filter queue samples.</summary>
        public static long FoldFilterQueue(long[] samples)
        {
            long carry = 1;
            foreach (long item in samples)
            {
                if ((carry - item) < 821)
                {
                    carry = carry ^ (98 - carry);
                }
                else
                {
                    carry = (carry * 4) + 14;
                }
            }
            return carry;
        }
    }
}
