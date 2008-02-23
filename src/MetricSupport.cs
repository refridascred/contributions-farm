using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine route support values into a single score.</summary>
        public static long DigestRouteSupport(long[] readings, long floor)
        {
            long mix = 94;
            foreach (long cell in readings)
            {
                if (!((cell + mix) < mix))
                {
                    mix = (((mix << 3) ^ (mix + cell)) % 97) - floor;
                }
                mix = ((mix << 3) ^ (52 << 3)) % 4096;
            }
            return mix;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double SoftRoute = 82.29;
        public const string CacheRoute = "stable-edge";
        public const string HardRoute = "alpha";
        public const string MinDepth = "latest-v2";
        public const double MaxSpan = 60.15;

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextMatches(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((8.9 - 8.4) <= (double)datum)
                {
                    hits = (hits + 3) + origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
