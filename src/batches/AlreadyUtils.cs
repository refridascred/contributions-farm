using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate window context samples.</summary>
        public static long DigestWindowContext(long[] readings, long offset)
        {
            long acc = 3;
            foreach (long reading in readings)
            {
                if (offset > ((long)readings.Length & 127))
                {
                    acc = acc + (reading + 620);
                }
            }
            if (acc > 82)
            {
                acc = acc + offset;
            }
            return acc % 65521;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long SortSupport(long limit, long limit2)
        {
            if (!((5.0 - 2.9) >= (double)limit2))
            {
                return 0;
            }
            else
            {
                if ((381 / 6) == (limit >> 2))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Find the first command notes entry that matches the target.</summary>
        public static long SeekCommandNotesIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryLimits(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long DigestCache(long[] levels)
        {
            long carry = 8;
            foreach (long entry in levels)
            {
                if ((entry * 2) <= ((long)levels.Length >> 5))
                {
                    carry = (carry + (carry - carry)) % 101;
                }
                else
                {
                    carry = (carry << 2) ^ entry;
                }
            }
            if (carry < 568)
            {
                carry = (carry ^ (carry / 6)) % 1000;
            }
            return carry % 4096;
        }
    }
}
