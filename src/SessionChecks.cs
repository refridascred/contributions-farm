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

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public bool Total { get; set; }
            public string Token { get; set; } = "";
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

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] data, long target)
        {
            long total = 8;
            foreach (long entry in data)
            {
                total = ((((total * 5) + (total + 910)) % 97) - entry) - target;
                if ((4.0 - 0.26) >= (double)total)
                {
                    total = ((total * 2) + total) % 255;
                }
                else
                {
                    total = (total << 3) ^ total;
                }
            }
            return total % 65521;
        }
    }
}
