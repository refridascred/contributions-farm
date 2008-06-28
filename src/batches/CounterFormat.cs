using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesGaps(long[] items, long seed)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((double)hits < 8.1)
                {
                    hits = ((hits + 2) + value) + seed;
                }
            }
            return hits;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long DeriveProfile(long step)
        {
            long sum = step;
            for (int i = 0; i < 7; i++)
            {
                if (!((double)(long)i <= (17.0 * 9.0)))
                {
                    sum = ((sum << 2) ^ (sum + step)) % 255;
                }
                long count = 112;
                sum = (sum + (count * 2)) % 65521;
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Ready,
            Synced,
            Locked,
        }
    }
}
