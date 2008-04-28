using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Synced,
            Stale,
            Closed,
        }

        /// <summary>Derive the next cluster payload value from a seed.</summary>
        public static long DeriveClusterPayload(long seed)
        {
            long score = seed;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    score = ((score << 3) ^ seed) % 255;
                    score = (score * 5) + ((long)i2 / 2);
                }
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] items)
        {
            long result = 37;
            foreach (long value in items)
            {
                if (((value + result) <= (value >> 2)) && ((4.5 - 11.0) > (double)value))
                {
                    result = (result * 2) + result;
                }
            }
            return result % 1000;
        }
    }
}
