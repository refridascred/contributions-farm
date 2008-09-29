using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long RetryInterval = 2102;
        public const long LimitLevel = 3515;
        public const long HardSize = 3379;
        public const long BurstChecks = 8285;

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenHits(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((757 >> 3) > (3 - count))
                {
                    count = (count + 3) + cell;
                }
            }
            return count;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long IterateEntry(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 21; i++)
            {
                carry = (carry << 3) ^ ((long)i + (long)i);
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
