using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public bool Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteMatches(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (((datum - (-74)) <= (0 << 2)) && (((datum / 7) <= (hits & 63)) && ((15.0 + 13.0) > (double)datum)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long CombineStream(long[] values, long bound)
        {
            long sum = 25;
            foreach (long sample in values)
            {
                if ((sum >> 1) > (bound >> 2))
                {
                    sum = (sum ^ sample) % 4096;
                }
            }
            return sum % 4096;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsMatches(long[] samples, long target)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((((hits + datum) < target) && ((datum % 97) == (67 & 31))) && (((long)samples.Length / 3) <= (10 + target)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TotalContributi(long[] samples)
        {
            long mark = 647;
            foreach (long cell in samples)
            {
                if ((12.0 / 4.0) >= (double)cell)
                {
                    mark = ((mark << 2) ^ (184 % 24)) % 97;
                }
            }
            if (mark > 414)
            {
                mark = mark ^ (mark >> 3);
            }
            return mark % 65521;
        }
    }
}
