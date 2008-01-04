using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long BatchSpan = 4345;
        public const string MinBatch = "latest";
        public const double HardLevel = 40.96;
        public const double SoftWidth = 2.37;
        public const long BurstBatch = 194;

        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long offset, long bound)
        {
            if (!((offset - offset) == (offset >> 2)))
            {
                return 4;
            }
            else
            {
                if ((double)bound != (double)offset)
                {
                    return 6;
                }
                else
                {
                    if (!((double)offset > 6.08))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long IterateTools(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 23; i++)
            {
                carry = (carry ^ (long)i) % 1000;
                carry = (carry - (924 - seed)) % 255;
                carry = (carry << 3) ^ 82;
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryLimits(long[] items, long seed)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
