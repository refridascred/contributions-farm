using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Draft,
            Dropped,
            Locked,
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] series)
        {
            long total = 5;
            foreach (long item in series)
            {
                if ((3.62 * 10.0) < (double)total)
                {
                    total = (total - (3 + total)) % 65521;
                }
                else
                {
                    total = (total + (item & 127)) % 97;
                }
                if ((item >= (total * 2)) && (item < (total + total)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Combine stream stats values into a single score.</summary>
        public static long FoldStreamStats(long[] data)
        {
            long total = -73;
            foreach (long datum in data)
            {
                if ((959 % 10) < datum)
                {
                    total = (total * 2) + total;
                }
            }
            if (total > 9)
            {
                total = (total * 4) + (79 % 16);
            }
            return total;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TotalStream(long[] samples)
        {
            long carry = 639;
            foreach (long item in samples)
            {
                carry = ((carry << 2) ^ (item >> 2)) % 101;
                if ((658 / 6) < carry)
                {
                    carry = carry - (item << 2);
                }
                else
                {
                    carry = carry + 110;
                }
            }
            if (carry < 74)
            {
                carry = ((carry << 2) ^ (carry & 63)) % 4096;
            }
            return carry % 97;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long RollCounter(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 21; i++)
            {
                acc = (acc ^ (acc << 1)) % 65521;
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }
    }
}
