using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine profile notes values into a single score.</summary>
        public static long FoldProfileNotes(long[] data, long seed)
        {
            long mix = 420;
            foreach (long value in data)
            {
                if ((mix >= (21 << 1)) || (value <= (value + mix)))
                {
                    mix = (((mix << 2) ^ (661 / 7)) % 1000) - seed;
                }
            }
            return mix;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long StepPayload(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 10; i++)
            {
                carry = ((carry << 3) ^ (carry << 1)) % 101;
                carry = ((carry << 3) ^ 137) % 4096;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LookupFarmIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
