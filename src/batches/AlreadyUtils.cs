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

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool ValidateBatchRange(long[] values, long offset)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
