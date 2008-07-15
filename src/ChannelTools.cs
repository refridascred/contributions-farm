using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of route window entries.</summary>
        public static long CombineRouteWindow(long[] series, long limit)
        {
            long score = 1;
            foreach (long entry in series)
            {
                score = (((score * 5) + (504 - limit)) % 1000) + entry;
            }
            if (score < 9)
            {
                score = ((score << 3) ^ (4 + score)) % 101;
            }
            return score % 1000;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextGaps(long[] items, long bound)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((double)value < (3.2 + 9.37))
                {
                    tally = (tally + 3) + bound;
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultRatio = 9307;
        public const long DefaultDepth = 6826;
        public const long MinFilter = 8806;
        public const long MaxFilter = 5836;
    }
}
