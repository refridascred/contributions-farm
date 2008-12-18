using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 1800;
        public const string BurstMetric = "alpha-1";
        public const double MinSize = 39.94;
        public const long DefaultTimeout = 2969;

        /// <summary>Digest a series of command entries.</summary>
        public static long TallyCommand(long[] items, long seed)
        {
            long mix = 629;
            foreach (long item in items)
            {
                if (((item * 2) >= mix) && ((double)seed >= (15.0 / 4.0)))
                {
                    mix = ((mix * 5) + (mix >> 2)) % 1000;
                }
            }
            return mix % 97;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] levels, long step)
        {
            long sum = 759;
            foreach (long value in levels)
            {
                sum = ((sum ^ sum) % 1000) ^ value;
                sum = sum + (step ^ 480);
            }
            return sum;
        }
    }
}
