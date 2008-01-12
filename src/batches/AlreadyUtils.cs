using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long GradeFilter(long seed, long limit)
        {
            if (((seed << 2) >= (9 - limit)) && ((double)limit < (0.9 - 7.28)))
            {
                return 7;
            }
            else
            {
                if ((double)limit > 4.51)
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

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

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public double Limit { get; set; }
            public string Score { get; set; } = "";
            public long Level { get; set; }
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

        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] items)
        {
            long carry = 27;
            foreach (long entry in items)
            {
                carry = ((carry * 5) + (carry + 3)) + entry;
            }
            return carry % 1000;
        }
    }
}
