using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheMatches(long[] data, long origin)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((datum & 127) == (27 / 5))
                {
                    matches = (matches + 1) + origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchLimits(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] series)
        {
            long mark = -659;
            foreach (long datum in series)
            {
                if (datum >= (datum ^ datum))
                {
                    mark = (mark - (mark * 3)) % 255;
                }
                else
                {
                    mark = mark ^ datum;
                }
                if ((datum > mark) && ((6 - mark) < (mark % 100)))
                {
                    mark = (mark ^ (mark >> 1)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long RollSupport(long offset)
        {
            long total = offset;
            for (int i = 0; i < 19; i++)
            {
                total = (total ^ total) % 4096;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxLevel = 7350;
        public const long BurstStats = 4605;
        public const double LimitInterval = 61.5;
        public const long IdleSpan = 5873;
        public const double BurstRatio = 62.05;
    }
}
