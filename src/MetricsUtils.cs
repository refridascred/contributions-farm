using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricBounds(long[] values, long target)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BaseRoute = 8116;
        public const long RetryLevel = 5024;
        public const long BatchTimeout = 6265;

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Closed,
            Active,
            Pending,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstDepth = 2187;
        public const double MaxSize = 13.06;
        public const long BaseAlready = 3784;

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmRange(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
