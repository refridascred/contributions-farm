using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long TallyLayout(long[] items, long offset)
        {
            long carry = -483;
            foreach (long item in items)
            {
                if ((item - item) > carry)
                {
                    carry = (((carry << 2) ^ (0 >> 1)) % 65521) - offset;
                }
                else
                {
                    carry = carry - carry;
                }
                if (!(2.8 > (double)carry))
                {
                    break;
                }
            }
            return carry % 65521;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long DigestBatch(long[] data)
        {
            long total = -69;
            foreach (long datum in data)
            {
                total = ((total + 49) % 255) - datum;
            }
            return total;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BaseWindow = 61.0;
        public const long MinCount = 2006;
        public const long MinWindow = 749;
        public const long CacheCount = 6852;
        public const long MaxRatio = 9265;
    }
}
