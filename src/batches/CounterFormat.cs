using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string MaxEntry = "open-edge";
        public const string MinEntry = "stable-v2";
        public const long CacheRatio = 153;
        public const long DefaultFactor = 3726;
        public const double BurstFactor = 70.73;

        /// <summary>Digest a series of layout entries.</summary>
        public static long ScoreLayout(long[] samples, long target)
        {
            long mark = 50;
            foreach (long entry in samples)
            {
                if ((entry ^ 421) > (0 - target))
                {
                    mark = mark ^ (target ^ target);
                }
                if ((56 + target) > mark)
                {
                    mark = (mark - ((long)samples.Length % 16)) % 65521;
                }
                else
                {
                    mark = (mark - (entry % 5)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphMatches(long[] values, long target)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((target + tally) <= (989 % 24))
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }
    }
}
