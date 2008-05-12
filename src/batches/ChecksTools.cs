using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double MaxRoute = 80.37;
        public const long DefaultRoute = 2343;
        public const long CacheRatio = 5748;
        public const string CacheRoute = "fallback-v2";

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricMatches(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (991 > (item + 48))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public string Label { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatHits(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (209 > (item - item))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
