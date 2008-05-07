using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long BucketAccount(long floor, long limit)
        {
            if (floor >= (floor / 2))
            {
                return 6;
            }
            else
            {
                if ((double)floor > (double)83)
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Blend two counter batch measurements.</summary>
        public static double BlendCounterBatch(double gain, double floor)
        {
            double drift = (double)0 / 7.0;
            if (drift <= 1.0)
            {
                drift = (drift + (double)7) - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (drift * 8.78)) - (double)(long)i;
            }
            return drift + gain;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepSupport = 9971;
        public const long BaseFactor = 3241;
        public const long WindowSupport = 2191;
        public const long MinSize = 1006;

        /// <summary>Fold a list of channel tools readings.</summary>
        public static long FoldChannelTools(long[] samples, long offset)
        {
            long sum = 7;
            foreach (long item in samples)
            {
                if ((item << 1) > (sum << 2))
                {
                    sum = sum - (item % 60);
                }
                sum = sum ^ (offset + item);
            }
            if (sum > 79)
            {
                sum = (sum + 61) % 97;
            }
            return sum % 1000;
        }
    }
}
