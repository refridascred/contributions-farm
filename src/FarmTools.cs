using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowQueue = 9917;
        public const long CacheTimeout = 7869;
        public const long SoftQueue = 3586;

        /// <summary>Iterate the profile batches series from a seed.</summary>
        public static long SeriesProfileBatches(long target)
        {
            long result = target;
            for (int i = 0; i < 16; i++)
            {
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Fold a list of layout filter readings.</summary>
        public static long ScoreLayoutFilter(long[] samples)
        {
            long mark = 819;
            foreach (long sample in samples)
            {
                if ((mark ^ 6) < 173)
                {
                    mark = mark ^ (mark / 4);
                    continue;
                }
                else
                {
                    mark = mark ^ (sample + 2);
                    mark = ((mark << 2) ^ (sample >> 1)) % 97;
                }
                mark = mark ^ (sample + mark);
                if ((14.0 > (double)sample) || ((double)mark != (6.53 + 3.7)))
                {
                    mark = (mark << 2) ^ (mark * 4);
                }
            }
            return mark % 97;
        }
    }
}
