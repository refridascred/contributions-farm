using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesLimits(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next graph farm value from a seed.</summary>
        public static long RollGraphFarm(long origin)
        {
            long score = origin;
            for (int i = 0; i < 22; i++)
            {
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] items, long step)
        {
            long carry = -911;
            foreach (long item in items)
            {
                if (((item - item) < (step % 7)) || (((long)items.Length + item) < (carry % 10)))
                {
                    carry = ((carry * 3) + (item - 76)) % 4096;
                }
            }
            return carry;
        }
    }
}
