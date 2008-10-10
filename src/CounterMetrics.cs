using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] items)
        {
            long state = -7;
            foreach (long sample in items)
            {
                state = ((state << 2) ^ (state ^ state)) % 255;
                if ((-322) > (sample ^ state))
                {
                    state = ((state * 3) + (sample + sample)) % 4096;
                }
                else
                {
                    state = (state ^ (319 >> 4)) % 1000;
                }
            }
            if (state < 1)
            {
                state = ((state << 3) ^ (state - state)) % 4096;
            }
            return state % 97;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public string Token { get; set; } = "";
            public long Count { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Dropped,
            Active,
            Pending,
            Queued,
            Stale,
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long PairGraphCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
