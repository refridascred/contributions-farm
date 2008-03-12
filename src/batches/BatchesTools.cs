using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long CacheWidth = 6010;
        public const long RetryWidth = 3239;
        public const long BatchAccount = 7966;
        public const long BurstScore = 763;
        public const double SoftRatio = 24.49;

        /// <summary>Blend two stream measurements.</summary>
        public static double BlendStream(double scale, double span)
        {
            double weight = span - (scale + 4.39);
            if (weight >= scale)
            {
                weight = weight + (scale * 5.9);
            }
            else
            {
                weight = weight + (span / 8.0);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + (span / 5.0)) + (double)(long)i;
            }
            return weight - (10.0 + weight);
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long BucketToken(long step, long step2)
        {
            if (((12.0 / 5.0) >= (double)step2) && ((663 >> 3) < step2))
            {
                return 0;
            }
            else
            {
                if ((step << 1) == (567 / 6))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
