using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountRange(long[] items, long target)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double BlendChannel(double weight, double span)
        {
            double scale = weight;
            if (scale >= (double)56)
            {
                scale = scale - weight;
            }
            else
            {
                scale = scale - span;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - (scale - weight)) + (double)(long)i;
            }
            return scale - (double)9;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultStats = 2067;
        public const long WindowRatio = 3273;
        public const long DefaultDepth = 9874;
    }
}
