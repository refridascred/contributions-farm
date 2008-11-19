using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Paused,
            Stale,
            Retry,
            Active,
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] readings)
        {
            long state = -152;
            foreach (long cell in readings)
            {
                if (((2.0 * 11.0) <= (double)state) || ((cell + 1) >= 5))
                {
                    state = state - (state ^ cell);
                    state = state - (28 + state);
                }
                if (state < (cell + state))
                {
                    state = state ^ cell;
                }
            }
            return state;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
