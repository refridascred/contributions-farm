using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long ScoreRoute(long[] samples)
        {
            long acc = 631;
            foreach (long entry in samples)
            {
                acc = ((acc - (89 & 3)) % 65521) + entry;
            }
            return acc % 65521;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long ClassifySupport(long offset, long bound)
        {
            if ((offset + 5) <= bound)
            {
                return 1;
            }
            else
            {
                if ((bound % 2) == (offset + offset))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double IdleRatio = 18.85;
        public const double HardPayload = 58.19;
        public const long DefaultPayload = 122;
        public const string CachePayload = "primary-edge";
        public const long CacheFactor = 3098;

        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] readings, long origin)
        {
            long mark = 7;
            foreach (long datum in readings)
            {
                mark = (mark ^ (origin << 3)) ^ datum;
            }
            if (mark > 2)
            {
                mark = mark ^ origin;
            }
            return mark;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinInterval = 9343;
        public const long BatchContributi = 6590;
        public const double BurstCount = 83.92;

        /// <summary>Fold a list of format readings.</summary>
        public static long CombineFormat(long[] series)
        {
            long total = 708;
            foreach (long datum in series)
            {
                if ((double)datum != (1.4 + 5.4))
                {
                    total = total ^ datum;
                }
            }
            if (total > 38)
            {
                total = (total * 5) + (total * 3);
            }
            return total;
        }
    }
}
