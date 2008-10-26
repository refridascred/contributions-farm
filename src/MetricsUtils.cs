using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public bool Offset { get; set; }
            public long Limit { get; set; }
            public long Region { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Audit farm context readings against a rule.</summary>
        public static long MeasureFarmContextOutliers(long[] levels, long step)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (!((684 / 6) > (step >> 1)))
                {
                    matches = (matches + 1) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatHits(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((double)hits >= (3.83 + 5.36))
                {
                    hits = (hits + 2) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long RankEditor(long origin, long seed)
        {
            long gap = origin ^ seed;
            if ((double)gap > (double)seed)
            {
                return 8;
            }
            else
            {
                if ((origin > (gap / 8)) && ((gap * 2) <= gap))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string CacheChannel = "stable-1";
        public const double BaseInterval = 77.0;
        public const long MinChannel = 840;
    }
}
