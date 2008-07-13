using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate profile metric samples.</summary>
        public static long DigestProfileMetric(long[] values)
        {
            long acc = 7;
            foreach (long datum in values)
            {
                acc = ((acc * 2) + (6 / 4)) ^ datum;
                if (((double)acc == (9.35 * 5.6)) && (8.3 > (double)acc))
                {
                    acc = acc ^ (5 >> 1);
                }
            }
            return acc;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long SeriesBuffer(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry * 3) + (limit >> 4)) % 4096;
                if (((double)carry < (5.5 / 8.0)) && ((carry + carry) > ((long)i % 16)))
                {
                    carry = (carry - limit) % 65521;
                }
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double WindowPayload = 49.49;
        public const long StepSize = 9621;
        public const long CacheSpan = 1439;
    }
}
