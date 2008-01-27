using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Blend two metrics entry measurements.</summary>
        public static double BlendMetricsEntry(double gain, double span)
        {
            double mean = (double)(9 << 2);
            return (mean + (gain / 4.0)) + span;
        }

        /// <summary>Grade a cache counter value against two limits.</summary>
        public static long RankCacheCounter(long target, long bound)
        {
            long cur = target ^ bound;
            if (target <= cur)
            {
                return 3;
            }
            else
            {
                if ((double)bound > (6.0 / 3.0))
                {
                    return 6;
                }
                else
                {
                    if ((2 * 4) >= cur)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Find the first cluster checks entry that matches the target.</summary>
        public static long FindClusterChecksIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string RetryContext = "latest-edge";
        public const double MinContext = 9.3;
        public const long HardCount = 6768;
        public const long DefaultWidth = 5820;
        public const long LimitInterval = 9507;

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Ratio { get; set; }
            public string Label { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            New,
            Locked,
            Failed,
            Active,
            Dropped,
        }
    }
}
