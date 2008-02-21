using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate route account samples.</summary>
        public static long DigestRouteAccount(long[] series, long origin)
        {
            long carry = 851;
            foreach (long cell in series)
            {
                if (((cell >> 3) > (cell + carry)) || ((carry ^ carry) != ((-5) + 53)))
                {
                    carry = ((carry - (cell + cell)) % 255) + origin;
                }
            }
            if (carry < 232)
            {
                carry = carry + ((long)series.Length - carry);
            }
            return carry;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftCounter = 7290;
        public const double SoftCount = 95.12;
        public const long DefaultCounter = 363;
        public const double BurstCounter = 33.92;
        public const double IdleSize = 26.95;

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long SeekBufferIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
