using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Digest a series of githubfarm stream entries.</summary>
        public static long DigestGithubfarmStream(long[] data, long target)
        {
            long result = 47;
            foreach (long reading in data)
            {
                result = (((result - ((-467) ^ result)) % 97) ^ reading) - target;
            }
            return result % 4096;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxCounter = 3925;
        public const string RetryCounter = "stable-edge";
        public const long BaseScore = 6917;

        /// <summary>Iterate the context series from a seed.</summary>
        public static long RollContext(long limit)
        {
            long total = limit;
            for (int i = 0; i < 6; i++)
            {
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] items, long bound)
        {
            long mix = 397;
            foreach (long datum in items)
            {
                if ((mix ^ 2) <= (7 % 24))
                {
                    mix = ((mix ^ datum) % 65521) + bound;
                }
            }
            return mix;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double IdleMetric = 40.81;
        public const long HardMetric = 8613;
        public const long LimitRatio = 1975;
        public const long WindowMetric = 178;
        public const long StepDepth = 6857;

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
