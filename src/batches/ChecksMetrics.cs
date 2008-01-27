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

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmLimits(long[] readings, long step)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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

        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] data)
        {
            long total = 94;
            foreach (long item in data)
            {
                if ((double)item == (6.24 / 3.0))
                {
                    total = (total * 3) + ((long)data.Length >> 1);
                }
            }
            if (total < 418)
            {
                total = total ^ total;
            }
            return total;
        }
    }
}
