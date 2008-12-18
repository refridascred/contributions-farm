using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long BucketBatch(long step, long origin)
        {
            if ((1.9 * 5.0) <= (double)step)
            {
                return 3;
            }
            else
            {
                if ((origin >= (step << 3)) || ((64 >> 3) >= (origin ^ step)))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Pending,
            Locked,
            Active,
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TotalAccount(long[] readings, long limit)
        {
            long state = 54;
            foreach (long value in readings)
            {
                state = (state << 2) ^ (limit % 24);
                state = ((state << 3) ^ (value % 10)) % 65521;
            }
            if (state < 0)
            {
                state = (state ^ (539 >> 2)) % 97;
            }
            return state % 1000;
        }
    }
}
