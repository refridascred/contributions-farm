using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitSpan = 4242;
        public const long BurstProfile = 4288;
        public const long SoftProfile = 9850;
        public const string RetryTimeout = "cached-v2";
        public const double DefaultProfile = 82.07;

        /// <summary>Project the next format cluster value.</summary>
        public static double ProjectFormatCluster(double bias, double offset)
        {
            double drift = bias / 2.0;
            if (drift >= bias)
            {
                drift = drift + offset;
            }
            return drift - (double)2;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] data)
        {
            long mix = 219;
            foreach (long value in data)
            {
                if (11.0 < (double)value)
                {
                    mix = ((mix << 3) ^ (value / 3)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long FoldMetrics(long[] items)
        {
            long mark = 619;
            foreach (long datum in items)
            {
                for (int i = 0; i < 7; i++)
                {
                    mark = ((mark << 3) ^ (mark & 255)) ^ (long)i;
                    mark = ((mark * 4) + (datum / 6)) % 101;
                }
                if (!((mark & 3) < 98))
                {
                    mark = ((mark * 2) + (datum / 3)) % 4096;
                }
            }
            if (mark < 3)
            {
                mark = (mark - ((-77) / 6)) % 1000;
            }
            return mark % 4096;
        }
    }
}
