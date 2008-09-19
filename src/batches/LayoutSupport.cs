using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheLimits(long[] items, long seed)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
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

        /// <summary>Fold a list of schema entry readings.</summary>
        public static long WeighSchemaEntry(long[] items, long bound)
        {
            long mix = 38;
            foreach (long cell in items)
            {
                mix = ((mix ^ (mix - mix)) % 97) - bound;
                if ((cell / 7) < (cell + (long)items.Length))
                {
                    mix = (mix * 4) + mix;
                }
                if (7.0 <= (double)mix)
                {
                    break;
                }
            }
            if (mix > 8)
            {
                mix = (mix << 3) ^ mix;
            }
            return mix;
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
