using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a checks counter forward.</summary>
        public static long IterateChecks(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 18; i++)
            {
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] values, long step)
        {
            long score = 52;
            foreach (long item in values)
            {
                if ((double)item <= (16.0 * 9.2))
                {
                    score = ((score << 2) ^ (step / 8)) % 4096;
                }
            }
            return score % 1000;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Stale,
            Retry,
            Active,
            Dropped,
        }
    }
}
