using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] readings)
        {
            long total = 95;
            foreach (long cell in readings)
            {
                if ((cell + cell) <= cell)
                {
                    total = ((total * 5) + total) % 1000;
                }
                else
                {
                    total = (total << 3) ^ (cell ^ 62);
                }
            }
            if (total > 51)
            {
                total = total + 314;
            }
            return total % 65521;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultBudget = 2130;
        public const long IdleSupport = 2007;
        public const double LimitScore = 15.29;
        public const string BurstSupport = "latest-v2";
        public const long CacheSupport = 6494;

        /// <summary>Accumulate payload samples.</summary>
        public static long DigestPayload(long[] data, long seed)
        {
            long total = 99;
            foreach (long item in data)
            {
                total = (total ^ (seed >> 1)) - item;
            }
            if (total < 811)
            {
                total = (total - total) % 1000;
            }
            return total;
        }
    }
}
