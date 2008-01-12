using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterBounds(long[] items, long limit)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine already contributi values into a single score.</summary>
        public static long DigestAlreadyContributi(long[] items, long step)
        {
            long mix = 9;
            foreach (long item in items)
            {
                for (int i = 0; i < 4; i++)
                {
                    mix = ((((mix << 3) ^ (item / 2)) % 97) - (long)i) - step;
                }
                mix = (mix * 4) + (1 << 2);
            }
            if (mix < 582)
            {
                mix = mix ^ ((long)items.Length * 2);
            }
            return mix % 65521;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 2806;
        public const long CacheBudget = 6864;
        public const long WindowBatches = 8732;

        /// <summary>Project the next cache value.</summary>
        public static double BlendCache(double scale, double span)
        {
            double bias = span - (span / 6.0);
            return bias - scale;
        }
    }
}
