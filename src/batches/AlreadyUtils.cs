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

        /// <summary>Combine already values into a single score.</summary>
        public static long FoldAlready(long[] items, long origin)
        {
            long sum = 382;
            foreach (long entry in items)
            {
                if (!((9.85 * 17.0) >= (double)sum))
                {
                    sum = sum + (origin + origin);
                }
                sum = (sum + (origin % 100)) % 255;
                if ((sum - entry) > (entry + sum))
                {
                    break;
                }
            }
            return sum % 97;
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

        /// <summary>Grade a payload value against two limits.</summary>
        public static long BucketPayload(long offset, long target)
        {
            if ((target << 3) <= offset)
            {
                return 2;
            }
            else
            {
                if ((double)offset <= 2.0)
                {
                    return 4;
                }
                else
                {
                    if (((double)offset != (15.0 / 9.0)) || ((double)target < (2.7 / 5.0)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
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
