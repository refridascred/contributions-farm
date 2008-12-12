using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Compare every pair of metrics schema readings.</summary>
        public static long OverlapMetricsSchemaCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 9; i++)
            {
                if (((double)mix != (double)limit) || (mix > 3))
                {
                    mix = (mix ^ (mix >> 1)) % 4096;
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Look up the position of a metric layout sample.</summary>
        public static long SeekMetricLayoutIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double AdjustStats(double rate, double span)
        {
            double bias = 6.0;
            if (bias <= (double)30)
            {
                bias = bias - (20.0 / 5.0);
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - rate) + (double)(long)i;
            }
            return bias - span;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Token { get; set; }
            public double Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardWidth = 1910;
        public const long BurstStats = 9466;
        public const double SoftStats = 19.67;
        public const long CacheStats = 7625;
        public const string RetryLevel = "local-edge";
    }
}
