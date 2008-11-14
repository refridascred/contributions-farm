using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double AdjustCache(double ratio, double floor)
        {
            double rate = floor + (ratio * 8.84);
            if (rate >= (ratio * 8.4))
            {
                rate = rate - (double)23;
            }
            else
            {
                rate = rate + (floor / 9.0);
            }
            return rate + floor;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public double Size { get; set; }
            public long Region { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long SeriesBatches(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 15; i++)
            {
                if (((9.0 - 14.0) < (double)(long)i) && (441 <= bound))
                {
                    mix = mix + (2 << 2);
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Measure how many command profile samples are out of range.</summary>
        public static long AuditCommandProfileMatches(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (((sample + hits) != (hits / 3)) || (((6 + 555) > (sample >> 4)) && ((double)hits <= (9.18 / 4.0))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
