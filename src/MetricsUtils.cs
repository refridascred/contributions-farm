using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long SoftWidth = 2658;
        public const long RetrySupport = 8217;
        public const double CacheSupport = 26.16;
        public const long BatchSupport = 8647;

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenRange(long[] samples, long offset)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 4; i++)
            {
                mark = mark + seed;
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowHits(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (((entry < (-6)) && ((entry & 3) >= entry)) || (hits >= (entry & 63)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of context batches entries.</summary>
        public static long TallyContextBatches(long[] series, long floor)
        {
            long anchor = -7;
            foreach (long sample in series)
            {
                if (((sample + sample) <= anchor) || ((floor ^ floor) != (floor << 2)))
                {
                    anchor = anchor - ((-4) ^ 750);
                }
            }
            if (anchor < 984)
            {
                anchor = ((anchor << 3) ^ (anchor + floor)) % 255;
            }
            return anchor;
        }
    }
}
