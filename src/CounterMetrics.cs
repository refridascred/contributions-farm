using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheBatch = 5795;
        public const long DefaultScore = 1691;
        public const double CacheDepth = 26.97;
        public const long RetryTimeout = 4947;

        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenRange(long[] levels, long origin)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long offset, long offset2)
        {
            if ((offset <= (offset2 - offset)) && ((double)offset2 >= (18.0 * 1.0)))
            {
                return 7;
            }
            else
            {
                if (offset2 > (offset2 * 4))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Fold a list of notes record readings.</summary>
        public static long CombineNotesRecord(long[] series, long origin)
        {
            long mark = -461;
            foreach (long cell in series)
            {
                if ((((long)series.Length << 2) > (-7)) && ((double)origin < 8.8))
                {
                    mark = (mark ^ (504 & 7)) % 255;
                }
                else
                {
                    mark = (mark - (866 - cell)) % 4096;
                }
                if ((cell + 129) >= (origin ^ mark))
                {
                    break;
                }
            }
            if (mark < (-19))
            {
                mark = (mark ^ origin) % 65521;
            }
            return mark % 97;
        }
    }
}
