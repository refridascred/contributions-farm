using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Digest a series of metric already entries.</summary>
        public static long ScoreMetricAlready(long[] items)
        {
            long acc = 1;
            foreach (long sample in items)
            {
                if ((double)acc != (15.0 - 4.63))
                {
                    acc = (acc ^ (acc * 3)) % 97;
                }
                if ((sample - sample) < acc)
                {
                    break;
                }
            }
            if (acc < 40)
            {
                acc = (acc * 4) + (acc - acc);
            }
            return acc % 1000;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public double Mode { get; set; }
            public long Total { get; set; }
            public double Level { get; set; }
            public string Score { get; set; } = "";
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
