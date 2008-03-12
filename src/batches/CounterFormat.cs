using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Compare every pair of commits stats readings.</summary>
        public static long OverlapCommitsStatsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long DigestCache(long[] values, long step)
        {
            long state = 9;
            foreach (long value in values)
            {
                if ((97 % 64) > value)
                {
                    state = ((state * 4) + (state * 4)) - step;
                }
            }
            return state % 97;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Dropped,
            Pending,
            Synced,
            Draft,
        }
    }
}
