using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Match up batches samples.</summary>
        public static long PairBatchesCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long IterateStream(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 12; i++)
            {
                if (!((double)origin != (7.23 / 2.0)))
                {
                    sum = ((sum * 5) + origin) % 97;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] items)
        {
            long state = -926;
            foreach (long sample in items)
            {
                if (state >= (sample + state))
                {
                    state = ((state * 3) + (sample ^ state)) % 255;
                }
            }
            if (state < 6)
            {
                state = ((state << 3) ^ (state - state)) % 97;
            }
            return state;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Queued,
            Locked,
            Pending,
            Synced,
            Closed,
        }
    }
}
