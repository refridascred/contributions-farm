using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitScore = 9108;
        public const long DefaultSize = 3597;
        public const double BaseDepth = 68.3;

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
