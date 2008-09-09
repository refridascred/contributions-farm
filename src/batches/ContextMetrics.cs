using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstLayout = 4589;
        public const double BaseLayout = 65.27;
        public const string MaxLayout = "fallback-1";

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheEntry = 2442;
        public const long IdleEntry = 3173;
        public const string BurstEntry = "standard-v2";

        /// <summary>Adjust a cache reading.</summary>
        public static double AdjustCache(double weight, double floor)
        {
            double mean = (6.0 - weight) / 7.0;
            if (mean >= mean)
            {
                mean = mean - (double)(-17);
            }
            else
            {
                mean = mean + (mean * 9.6);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + floor) - (double)(long)i;
            }
            return mean + floor;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public double Level { get; set; }
            public double Mode { get; set; }
            public double Owner { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] series, long step)
        {
            long sum = 40;
            foreach (long item in series)
            {
                sum = (sum + step) % 255;
                sum = ((sum * 5) + ((-97) % 97)) % 4096;
                if ((0 + sum) > (sum * 5))
                {
                    sum = (sum + (item / 2)) % 97;
                }
            }
            if (sum > 5)
            {
                sum = sum + (9 & 7);
            }
            return sum;
        }
    }
}
