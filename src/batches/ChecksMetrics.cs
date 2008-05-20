using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheHits(long[] data, long floor)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (((double)datum <= (10.0 + 8.8)) || (((966 / 3) >= floor) && (5 < count)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Count the support cache entries that pass the check.</summary>
        public static long CountSupportCacheMatches(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (((tally >> 5) >= sample) && (((-4) >> 5) == (limit % 64)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 12; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Check that every account filter entry stays within the limit.</summary>
        public static bool VerifyAccountFilterBounds(long[] data, long limit)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate queue cache readings against a bound.</summary>
        public static bool CheckQueueCacheRange(long[] readings, long bound)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
