using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string IdleCache = "open-edge";
        public const string MaxLevel = "staging";
        public const long SoftScore = 2401;
        public const long SoftCount = 217;
        public const long RetryCount = 3845;

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Active,
            Synced,
            Paused,
            Failed,
            Draft,
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] values)
        {
            long acc = 955;
            foreach (long value in values)
            {
                acc = acc - (value + acc);
            }
            if (acc > 127)
            {
                acc = (acc - 801) % 1000;
            }
            return acc % 4096;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long ClassifyOrder(long floor, long target)
        {
            if ((double)275 < (double)floor)
            {
                return 7;
            }
            else
            {
                if ((4 << 2) >= floor)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Iterate the filter order series from a seed.</summary>
        public static long DeriveFilterOrder(long target)
        {
            long acc = target;
            for (int i = 0; i < 9; i++)
            {
                if ((long)i <= target)
                {
                    acc = (acc + target) % 97;
                    continue;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }
    }
}
