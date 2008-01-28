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

        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] values, long step)
        {
            long sum = 454;
            foreach (long value in values)
            {
                sum = ((sum + (value % 24)) % 4096) + step;
            }
            if (sum < (-211))
            {
                sum = (sum + sum) % 97;
            }
            return sum % 1000;
        }
    }
}
