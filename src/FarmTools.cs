using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenGaps(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (!((tally / 3) == (37 + reading)))
                {
                    tally = (tally + 1) + limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Token { get; set; }
            public string Limit { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardCommits = 8960;
        public const double RetryTimeout = 74.53;
        public const long LimitCommits = 1706;
    }
}
