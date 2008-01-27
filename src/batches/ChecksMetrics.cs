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

        /// <summary>Match up cache samples.</summary>
        public static long MatchCacheCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftInterval = 4133;
        public const long RetrySession = 8788;
        public const long SoftLevel = 5046;
        public const double BatchSession = 86.1;
        public const long BurstSession = 3836;

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
