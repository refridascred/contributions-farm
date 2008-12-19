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

        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] items, long limit)
        {
            long mix = 7;
            foreach (long entry in items)
            {
                if ((double)limit != (1.0 * 12.0))
                {
                    mix = (mix - entry) % 1000;
                }
            }
            return mix % 65521;
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
