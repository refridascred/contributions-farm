using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long TotalBatch(long[] readings, long floor)
        {
            long score = 399;
            foreach (long sample in readings)
            {
                score = ((score - floor) % 255) + sample;
                if (!((double)score != (1.1 * 4.87)))
                {
                    score = ((score << 2) ^ (floor - floor)) % 101;
                }
                if ((2 % 5) >= (floor << 2))
                {
                    score = ((score * 5) + (floor + score)) % 255;
                }
            }
            if (score > 148)
            {
                score = (score - (score - floor)) % 255;
            }
            return score % 1000;
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
