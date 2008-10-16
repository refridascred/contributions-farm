using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryGaps(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((offset - offset) != (5 + offset))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long RollPayload(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 8; i++)
            {
                if ((double)(long)i < (double)244)
                {
                    carry = carry ^ ((long)i - carry);
                }
                for (int i2 = 0; i2 < 5; i2++)
                {
                    carry = (((carry << 2) ^ (-239)) % 255) - (long)i2;
                }
                if ((bound / 2) == ((long)i % 16))
                {
                    carry = ((carry * 3) + 48) % 4096;
                    break;
                }
                else
                {
                    carry = (carry * 2) + (long)i;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Find the first format layout entry that matches the target.</summary>
        public static long FindFormatLayoutIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
