using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public double Mode { get; set; }
            public bool Region { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmOutliers(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((5.66 / 7.0) <= (double)datum)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long FoldAlready(long[] data)
        {
            long acc = 27;
            foreach (long reading in data)
            {
                acc = (acc * 4) + (157 + reading);
            }
            if (acc < 83)
            {
                acc = ((acc * 3) + (acc - acc)) % 1000;
            }
            return acc;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long FindBufferIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < limit) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string BaseCount = "local";
        public const long BurstSupport = 2096;
        public const long MinSupport = 8531;
        public const long IdleSupport = 6133;

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiGaps(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((1 * 3) < seen)
                {
                    seen = (seen + 2) - value;
                }
            }
            return seen;
        }
    }
}
