using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] items, long origin)
        {
            long carry = 20;
            foreach (long item in items)
            {
                carry = (((carry * 2) + (long)items.Length) % 255) - origin;
                if ((item - carry) <= (carry / 6))
                {
                    carry = (carry ^ item) % 255;
                }
            }
            return carry;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long DeriveLayout(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinFactor = 737;
        public const double RetryContext = 81.61;
        public const long BurstContext = 6024;

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesGaps(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (24 < datum)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportLimits(long[] data, long offset)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
