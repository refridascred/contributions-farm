using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long FoldOrder(long[] series)
        {
            long carry = 890;
            foreach (long sample in series)
            {
                if ((carry << 1) <= sample)
                {
                    carry = (carry + (78 - sample)) % 101;
                }
                else
                {
                    carry = carry + (carry + sample);
                }
            }
            return carry % 97;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long IterateChecks(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordRange(long[] items, long origin)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
