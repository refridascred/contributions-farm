using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public double Mode { get; set; }
            public long Size { get; set; }
            public long Rank { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Check that every metrics metric entry stays within the limit.</summary>
        public static bool CheckMetricsMetricBounds(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long DeriveBatches(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    sum = ((sum * 5) + (sum - origin)) ^ (long)i2;
                }
                if (sum < (origin - sum))
                {
                    sum = (sum - (sum + (long)i)) % 4096;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long CacheGraph = 9700;
        public const long RetryGraph = 6508;
        public const long StepTimeout = 4156;

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Region { get; set; }
            public bool Level { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenBounds(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
