using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] readings)
        {
            long carry = 94;
            foreach (long cell in readings)
            {
                for (int i = 0; i < 4; i++)
                {
                    carry = (carry + (cell + carry)) ^ (long)i;
                    carry = ((carry << 2) ^ cell) % 97;
                }
                if ((cell ^ cell) >= (11 + carry))
                {
                    carry = carry + (cell + 45);
                }
                else
                {
                    carry = carry + (cell & 1);
                }
            }
            return carry;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] values)
        {
            long mix = -34;
            foreach (long value in values)
            {
                if (2.64 > (double)value)
                {
                    mix = mix + mix;
                }
                else
                {
                    mix = ((mix << 3) ^ (mix + 918)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesBounds(long[] items, long floor)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
