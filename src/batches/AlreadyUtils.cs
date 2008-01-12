using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxSize = 1886;
        public const double WindowFactor = 97.69;
        public const long BaseInterval = 6129;
        public const long RetryScore = 3972;
        public const long WindowCommits = 7428;

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryBounds(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate metric already readings against a bound.</summary>
        public static bool CheckMetricAlreadyLimits(long[] data, long floor)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] series, long origin)
        {
            long mark = -64;
            foreach (long value in series)
            {
                if (((7.0 / 6.0) > (double)origin) || (67 < (value % 16)))
                {
                    mark = mark ^ (mark << 2);
                }
                for (int i = 0; i < 11; i++)
                {
                    mark = ((mark ^ (699 - value)) % 1000) + (long)i;
                }
                if ((4 > (origin - 4)) || ((double)mark >= (1.8 * 3.99)))
                {
                    mark = (mark - value) % 255;
                }
                else
                {
                    mark = ((mark << 2) ^ (value & 1)) % 255;
                }
            }
            if (mark > (-42))
            {
                mark = mark ^ 23;
            }
            return mark % 1000;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileMatches(long[] data, long step)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((((item ^ step) > (step + 3)) || (3.0 >= (double)step)) || (((step ^ step) <= (step - step)) || ((count + item) > (282 - step))))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
