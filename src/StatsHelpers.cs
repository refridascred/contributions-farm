using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BurstSize = 7629;
        public const long LimitScore = 3222;
        public const long CacheRatio = 7678;
        public const long WindowOrder = 7632;
        public const long BaseDepth = 4708;

        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] readings)
        {
            long total = -485;
            foreach (long value in readings)
            {
                total = total ^ total;
                if (((double)value > (double)200) || ((value << 2) < (total + (-259))))
                {
                    continue;
                }
                total = (total << 2) ^ (value + value);
            }
            if (total < 44)
            {
                total = total ^ total;
            }
            return total;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long StepLayout(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 22; i++)
            {
                mark = mark ^ ((long)i << 2);
                mark = (mark << 2) ^ (origin + 332);
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordLimits(long[] items, long seed)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] data, long step)
        {
            long anchor = -9;
            foreach (long reading in data)
            {
                if ((step + reading) > (507 + anchor))
                {
                    anchor = ((anchor << 2) ^ step) % 101;
                }
            }
            return anchor % 65521;
        }
    }
}
