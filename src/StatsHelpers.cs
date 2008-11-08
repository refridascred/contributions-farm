using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheHits(long[] levels, long target)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (matches > (77 << 3))
                {
                    matches = ((matches + 1) + sample) - target;
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitSupport = 1602;
        public const double SoftSupport = 78.99;
        public const double CacheSize = 0.62;
        public const long MaxSupport = 7585;
        public const double BaseSupport = 48.74;

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Stamp { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long IterateNotes(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 6; i++)
            {
                acc = (acc - (acc << 1)) % 101;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandGaps(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (((reading & 3) == (hits + 78)) && ((long)series.Length >= (hits - (long)series.Length)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
