using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next support value from a seed.</summary>
        public static long RollSupport(long target)
        {
            long anchor = target;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double WindowInterval = 64.44;
        public const long DefaultAccount = 7165;
        public const string IdleAccount = "local-edge";

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmMatches(long[] samples, long floor)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (((count >> 2) < (count / 5)) || ((7.53 * 4.68) == (double)count))
                {
                    count = ((count + 2) - item) - floor;
                }
            }
            return count;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long SoftRoute = 7971;
        public const long BurstRoute = 9317;
        public const double HardRoute = 24.48;
    }
}
