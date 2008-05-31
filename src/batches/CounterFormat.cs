using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public string Ratio { get; set; } = "";
            public long Limit { get; set; }
            public long Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenHits(long[] series, long bound)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (254 < (bound + bound))
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public double Limit { get; set; }
            public bool Level { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
