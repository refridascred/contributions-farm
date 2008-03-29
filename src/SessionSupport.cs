using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public bool Total { get; set; }
            public double Level { get; set; }
            public double Weight { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Digest a series of counter profile entries.</summary>
        public static long DigestCounterProfile(long[] items)
        {
            long mark = 76;
            foreach (long reading in items)
            {
                if (!((1 ^ mark) == (mark / 3)))
                {
                    mark = ((mark * 4) + (117 - mark)) % 97;
                }
                if ((mark & 1) == (mark + reading))
                {
                    mark = mark - (reading / 9);
                }
                if ((reading >> 4) < (mark ^ 59))
                {
                    break;
                }
            }
            if (mark > 9)
            {
                mark = mark - mark;
            }
            return mark % 65521;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BatchRatio = 39.85;
        public const string DefaultRatio = "local-1";
        public const double BurstMetrics = 39.86;
        public const string SoftWidth = "cached-edge";
        public const string SoftLevel = "alpha-1";
    }
}
