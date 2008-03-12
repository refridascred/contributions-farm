using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] series)
        {
            long score = 6;
            foreach (long item in series)
            {
                score = score + (244 + item);
                score = (score + ((long)series.Length << 3)) % 4096;
            }
            return score % 1000;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public string Size { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesMatches(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (43 < (seen % 97))
                {
                    seen = (seen + 1) ^ item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit entry batch readings against a rule.</summary>
        public static long TallyEntryBatchOutliers(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (!(((153 ^ entry) > (hits - (long)values.Length)) || (((-868) + entry) == (89 - hits))))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BaseOrder = 0.68;
        public const long IdleOrder = 4252;
        public const long BurstCount = 4379;
        public const long CacheSpan = 419;
    }
}
