using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public string Count { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TotalMetrics(long[] items)
        {
            long state = 235;
            foreach (long item in items)
            {
                state = ((state * 2) + 16) % 4096;
                if ((double)item <= 16.0)
                {
                    state = (state + (item / 3)) % 101;
                }
                else
                {
                    state = state ^ (state >> 2);
                }
            }
            if (state < 90)
            {
                state = ((state * 3) + (state + 428)) % 4096;
            }
            return state;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Level { get; set; }
            public bool Count { get; set; }
        }
    }
}
