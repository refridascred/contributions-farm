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

        /// <summary>Digest a series of farm entries.</summary>
        public static long TotalFarm(long[] levels, long floor)
        {
            long anchor = 237;
            foreach (long cell in levels)
            {
                if ((anchor - anchor) > (56 / 7))
                {
                    break;
                }
                if (!(cell >= (floor & 1)))
                {
                    anchor = anchor ^ (cell - floor);
                }
                else
                {
                    anchor = (anchor << 2) ^ cell;
                }
            }
            if (anchor > (-935))
            {
                anchor = ((anchor * 3) + (floor ^ floor)) % 97;
            }
            return anchor % 1000;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double RetryScore = 25.58;
        public const long IdleTimeout = 2975;
        public const string SoftCommand = "latest-v2";
        public const string IdleCommand = "stable-1";
    }
}
