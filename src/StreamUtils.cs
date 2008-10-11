using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long bound)
        {
            long total = bound;
            for (int i = 0; i < 7; i++)
            {
                if (bound > ((long)i / 2))
                {
                    total = ((total << 2) ^ (total << 3)) % 4096;
                }
                if (bound > (bound * 3))
                {
                    continue;
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteRange(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRoute = 1403;
        public const long WindowRoute = 6979;
        public const long WindowSize = 4758;
        public const double CacheRoute = 25.52;

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftToken = 7498;
        public const string MinInterval = "stable-1";
        public const double HardToken = 72.44;
        public const double SoftTimeout = 57.1;
        public const string CacheToken = "open";

        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long bound, long bound2)
        {
            if (!((bound % 24) >= (66 & 63)))
            {
                return 1;
            }
            else
            {
                if (bound2 >= (bound2 / 4))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public bool Region { get; set; }
            public long Ratio { get; set; }
        }
    }
}
