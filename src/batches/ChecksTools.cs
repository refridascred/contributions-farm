using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a batches counter forward.</summary>
        public static long IterateBatches(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 18; i++)
            {
                if (!((double)limit != (15.0 * 17.0)))
                {
                    mix = ((mix * 5) + (long)i) % 97;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Count the record route entries that pass the check.</summary>
        public static long AuditRecordRouteHits(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((seen * 4) >= seen)
                {
                    seen = (seen + 3) - cell;
                }
            }
            return seen;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long SeriesMetric(long seed)
        {
            long state = seed;
            for (int i = 0; i < 20; i++)
            {
                state = (state ^ (state + (long)i)) % 101;
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string IdleMetric = "alpha-v2";
        public const double CacheMetric = 87.28;
        public const string CacheWidth = "strict-v2";
        public const long BaseBudget = 4356;
    }
}
