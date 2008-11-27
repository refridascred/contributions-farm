using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long SeriesFarm(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc ^ (702 / 7)) % 1000;
                acc = acc ^ 402;
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsMatches(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (((matches + matches) < (datum << 1)) || (((matches * 5) > (986 + datum)) && (matches < datum)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultSchema = 3532;
        public const long MinWidth = 934;
        public const long RetrySchema = 198;
        public const long DefaultSize = 2799;

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long DeriveStats(long offset)
        {
            long total = offset;
            for (int i = 0; i < 12; i++)
            {
                total = (total ^ total) % 1000;
                total = (total * 3) + ((long)i * 5);
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenHits(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((datum * 5) <= (hits + hits))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public string Flag { get; set; } = "";
            public string Size { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
