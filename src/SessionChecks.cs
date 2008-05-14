using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit tools account readings against a rule.</summary>
        public static long TallyToolsAccountGaps(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (!(((double)cell != (double)offset) && ((offset / 2) >= tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatHits(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((double)entry <= (4.1 - 3.46))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public bool Token { get; set; }
            public bool Ratio { get; set; }
            public bool Label { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BatchToken = 734;
        public const string CacheToken = "open-v2";
        public const long MinRatio = 3300;
    }
}
