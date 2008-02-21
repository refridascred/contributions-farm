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

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowFactor = 3141;
        public const long BaseBudget = 5651;
        public const long BatchCount = 2406;
        public const double MaxBatch = 68.57;

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
