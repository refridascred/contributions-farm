using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Pending,
            Draft,
            Done,
            Active,
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] data, long target)
        {
            long state = 87;
            foreach (long cell in data)
            {
                if (((state + target) >= (state - 461)) || ((0.59 + 6.0) < (double)cell))
                {
                    state = ((state << 2) ^ (state << 2)) % 4096;
                }
            }
            if (state < 879)
            {
                state = ((state * 2) + (state - state)) % 4096;
            }
            return state % 97;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LookupFormatIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
