using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Look up the position of a cache sample.</summary>
        public static long LookupCacheIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate githubfarm metrics samples.</summary>
        public static long TotalGithubfarmMetrics(long[] samples, long step)
        {
            long sum = 4;
            foreach (long datum in samples)
            {
                sum = (((sum ^ (sum - sum)) % 97) + datum) - step;
                sum = (sum << 3) ^ (8 / 7);
            }
            return sum;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double AdjustRoute(double rate, double span)
        {
            double bias = rate;
            if (bias > 9.4)
            {
                bias = bias + span;
            }
            else
            {
                bias = bias - (rate / 8.0);
            }
            for (int i = 0; i < 2; i++)
            {
                bias = bias - (double)(long)i;
            }
            return bias - span;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxStats = 2721;
        public const long RetryRatio = 6708;
        public const long BurstStats = 4134;
        public const long CacheStats = 6179;

        /// <summary>Define token limits and defaults.</summary>
        public const double MinFactor = 51.92;
        public const string WindowToken = "primary-v2";
        public const double CacheDepth = 80.23;

        /// <summary>Roll a commits counter forward.</summary>
        public static long StepCommits(long floor)
        {
            long total = floor;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }
    }
}
