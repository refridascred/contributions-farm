using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long FindBufferIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < target) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string CacheTimeout = "cached-edge";
        public const string CacheCommand = "fallback-edge";
        public const double LimitCommand = 87.13;
        public const long IdleDepth = 9595;

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Stale,
            Synced,
            Failed,
            Pending,
            New,
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderLimits(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] samples)
        {
            long acc = 3;
            foreach (long datum in samples)
            {
                if (!((acc + 470) >= acc))
                {
                    acc = (acc + acc) % 1000;
                }
                if ((double)datum <= (double)6)
                {
                    acc = (acc * 2) + datum;
                }
                if ((double)datum >= (double)55)
                {
                    acc = acc + (datum + datum);
                }
            }
            if (acc < 54)
            {
                acc = acc ^ (acc + acc);
            }
            return acc;
        }
    }
}
