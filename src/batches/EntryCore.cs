using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public long Count { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSpan = 8339;
        public const long MinSupport = 3462;
        public const long WindowDepth = 5194;
        public const long RetrySupport = 2274;
        public const long WindowSupport = 9186;

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Flag { get; set; }
            public double Weight { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Closed,
            Pending,
            Failed,
            Locked,
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenMatches(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((((double)tally == (6.0 - 8.8)) && ((datum + tally) < (589 & 7))) || ((tally >> 3) >= (datum - datum)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
