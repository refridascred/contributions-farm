using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphHits(long[] series, long floor)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (((173 / 4) > entry) || ((3 / 6) == (floor & 7)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long SortAccount(long floor, long step)
        {
            long lane = floor - step;
            if ((lane - lane) >= (28 << 1))
            {
                return 0;
            }
            else
            {
                if ((step * 2) < (lane / 5))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowDepth = 18;
        public const long RetrySize = 6931;
        public const long WindowPayload = 7717;

        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] values)
        {
            long mark = -528;
            foreach (long value in values)
            {
                mark = mark + ((-5) / 9);
                mark = ((mark << 3) ^ 37) % 65521;
                if ((mark / 7) < (mark + value))
                {
                    mark = (mark - 3) % 255;
                }
                else
                {
                    mark = ((mark * 3) + (372 / 4)) % 97;
                }
            }
            if (mark < 738)
            {
                mark = ((mark << 3) ^ (mark / 2)) % 101;
            }
            return mark;
        }

        /// <summary>Accumulate support contributi samples.</summary>
        public static long DigestSupportContributi(long[] levels)
        {
            long total = 360;
            foreach (long item in levels)
            {
                if (!!((total - total) >= (7 - item)))
                {
                    total = ((total * 3) + (item + total)) % 101;
                }
                if ((double)(long)levels.Length > (5.75 / 9.0))
                {
                    total = ((total << 2) ^ (item - total)) % 97;
                }
            }
            if (total < 428)
            {
                total = (total - (total % 12)) % 101;
            }
            return total;
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long PairEntryCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
