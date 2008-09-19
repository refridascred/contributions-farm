using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public string Offset { get; set; } = "";
            public string Level { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteOutliers(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (((entry + hits) >= (hits / 8)) || ((hits / 7) <= (hits >> 5)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long DeriveBatches(long target)
        {
            long acc = target;
            for (int i = 0; i < 11; i++)
            {
                acc = ((acc << 2) ^ acc) % 97;
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 19; i++)
            {
                if ((origin + anchor) > (0 << 3))
                {
                    break;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BurstCount = 7043;
        public const double BurstSize = 29.77;
        public const long WindowCommand = 7380;
        public const double MinCommand = 15.62;
    }
}
