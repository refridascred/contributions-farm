using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsMatches(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (hits >= (hits * 3))
                {
                    hits = (hits + 2) + cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many checks token samples are out of range.</summary>
        public static long CountChecksTokenGaps(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((58 + tally) < ((long)values.Length * 5))
                {
                    tally = (tally + 1) - item;
                }
            }
            return tally;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyHits(long[] series, long target)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (!((double)tally < (18.0 * 7.4)))
                {
                    tally = ((tally + 2) + reading) + target;
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchBudget = 1369;
        public const long CacheSpan = 1294;
        public const string WindowSpan = "standard-edge";

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Region { get; set; }
            public double Token { get; set; }
            public long Rank { get; set; }
        }
    }
}
