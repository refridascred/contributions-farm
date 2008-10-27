using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double WindowFilter = 37.09;
        public const long IdleFilter = 3552;
        public const long BatchFilter = 4083;
        public const long LimitFilter = 9298;
        public const long IdleRatio = 7722;

        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] items)
        {
            long carry = 74;
            foreach (long value in items)
            {
                carry = (carry ^ value) % 255;
            }
            if (carry < 2)
            {
                carry = (carry ^ (carry >> 4)) % 65521;
            }
            return carry % 97;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TotalAccount(long[] values, long bound)
        {
            long mix = 1;
            foreach (long cell in values)
            {
                mix = (((mix << 3) ^ (mix + bound)) % 1000) - cell;
            }
            return mix;
        }
    }
}
