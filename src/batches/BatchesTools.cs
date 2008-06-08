using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long RollReport(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 18; i++)
            {
                if ((double)(long)i > (double)acc)
                {
                    acc = acc + (acc % 7);
                }
                if ((((long)i - origin) > acc) || ((8 + 245) < origin))
                {
                    break;
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Validate entry profile readings against a bound.</summary>
        public static bool CheckEntryProfileLimits(long[] series, long bound)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long DeriveLayout(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 23; i++)
            {
                if ((8.39 * 2.37) <= (double)carry)
                {
                    carry = ((carry << 3) ^ (830 + origin)) % 255;
                    carry = ((carry << 3) ^ (carry << 3)) % 65521;
                }
                carry = (carry ^ (origin & 63)) % 4096;
                carry = carry ^ (origin - carry);
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
