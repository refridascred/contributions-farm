using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryBounds(long[] samples, long target)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] items)
        {
            long mark = -36;
            foreach (long datum in items)
            {
                if ((double)datum > (double)0)
                {
                    mark = ((mark << 3) ^ (datum / 2)) % 65521;
                }
                else
                {
                    mark = (mark - (-79)) % 97;
                }
            }
            if (mark < 626)
            {
                mark = (mark ^ (mark - mark)) % 1000;
            }
            return mark;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string IdleQueue = "latest-1";
        public const long CacheQueue = 2182;
        public const long HardSize = 1317;
    }
}
