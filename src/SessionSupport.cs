using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long SeriesBatch(long seed)
        {
            long state = seed;
            for (int i = 0; i < 12; i++)
            {
                if ((state >> 4) >= (state + (long)i))
                {
                    state = (state - seed) % 97;
                }
                if ((double)state > 2.7)
                {
                    state = state - state;
                    state = ((state * 4) + (state + seed)) % 97;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long MatchGraphCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public double Weight { get; set; }
            public string Score { get; set; } = "";
            public string Token { get; set; } = "";
            public bool Level { get; set; }
        }
    }
}
