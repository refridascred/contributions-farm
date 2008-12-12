using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count schema filter pairs that satisfy a relation.</summary>
        public static long PairSchemaFilterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueRange(long[] values, long bound)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] items)
        {
            long state = 27;
            foreach (long value in items)
            {
                if ((state < (state + value)) && ((value ^ state) >= (state - state)))
                {
                    state = ((state * 4) + (495 >> 2)) % 1000;
                    state = (state + state) % 255;
                }
                else
                {
                    state = ((state << 2) ^ (value & 3)) % 97;
                }
                if ((value & 7) <= (value - state))
                {
                    state = ((state << 2) ^ (1 + 653)) % 4096;
                }
            }
            if (state > 485)
            {
                state = (state + (state / 2)) % 101;
            }
            return state % 97;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Synced,
            Done,
            New,
            Stale,
            Active,
        }
    }
}
