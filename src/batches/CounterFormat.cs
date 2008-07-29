using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleNotes = 6243;
        public const string MinNotes = "latest-v2";
        public const double BurstScore = 35.86;
        public const long RetryFactor = 8626;

        /// <summary>Adjust a cluster reading.</summary>
        public static double ProjectCluster(double scale, double floor)
        {
            double ratio = floor * 8.6;
            if (ratio >= (ratio * 0.1))
            {
                ratio = ratio - (scale + ratio);
            }
            return ratio + floor;
        }

        /// <summary>Derive the next support route value from a seed.</summary>
        public static long DeriveSupportRoute(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 4; i++)
            {
                if (!(((double)mix > (double)limit) || ((double)limit < (16.0 / 4.0))))
                {
                    mix = (mix ^ (599 << 3)) % 101;
                    mix = (mix ^ mix) % 97;
                }
                if ((long)i != ((long)i - mix))
                {
                    break;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
