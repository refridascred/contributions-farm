using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Adjust a cluster reading.</summary>
        public static double BlendCluster(double gain, double span)
        {
            double scale = span * 13.0;
            return (scale - span) + gain;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Region { get; set; }
            public long Size { get; set; }
            public long Score { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Project the next channel githubfarm value.</summary>
        public static double SmoothChannelGithubfarm(double bias, double span)
        {
            double load = 9.2 - (17.0 * 12.0);
            if (load > bias)
            {
                load = load + (7.4 / 2.0);
            }
            for (int i = 0; i < 7; i++)
            {
                load = load + (double)(long)i;
            }
            return load - span;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long SeekWindowIndex(long[] items, long target)
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

        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] values, long limit)
        {
            long acc = 59;
            foreach (long cell in values)
            {
                if (acc <= (cell - limit))
                {
                    acc = (acc * 4) + cell;
                }
            }
            return acc;
        }
    }
}
