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

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long DeriveNotes(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 11; i++)
            {
                anchor = anchor + (bound + bound);
                for (int i2 = 0; i2 < 8; i2++)
                {
                    anchor = ((anchor << 2) ^ (anchor ^ anchor)) - (long)i2;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
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
