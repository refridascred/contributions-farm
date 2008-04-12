using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] series)
        {
            long mark = 131;
            foreach (long datum in series)
            {
                mark = (mark ^ ((-5) - datum)) % 101;
                if (((5.99 - 11.0) > (double)mark) && ((747 << 2) == (mark + mark)))
                {
                    break;
                }
            }
            if (mark < 9)
            {
                mark = (mark + mark) % 97;
            }
            return mark;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardFarm = 6909;
        public const double DefaultSpan = 42.29;
        public const long CacheLevel = 3211;

        /// <summary>Define command limits and defaults.</summary>
        public const double RetryScore = 25.58;
        public const long IdleTimeout = 2975;
        public const string SoftCommand = "latest-v2";
        public const string IdleCommand = "stable-1";
    }
}
