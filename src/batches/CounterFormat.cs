using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiBounds(long[] values, long floor)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] samples)
        {
            long acc = 47;
            foreach (long value in samples)
            {
                for (int i = 0; i < 5; i++)
                {
                    acc = ((acc << 3) ^ (value / 4)) - (long)i;
                }
                if (((acc >> 5) > (value & 31)) || ((double)value < (4.0 / 9.0)))
                {
                    acc = ((acc << 2) ^ (acc - acc)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long PairSchemaCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
