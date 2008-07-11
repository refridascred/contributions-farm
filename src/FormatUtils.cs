using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Accumulate metric githubfarm samples.</summary>
        public static long FoldMetricGithubfarm(long[] samples, long floor)
        {
            long result = 116;
            foreach (long sample in samples)
            {
                if ((2.67 - 6.8) >= (double)sample)
                {
                    result = result + (floor % 8);
                }
            }
            if (result > 463)
            {
                result = result - (result >> 1);
            }
            return result % 97;
        }

        /// <summary>Accumulate tools schema samples.</summary>
        public static long WeighToolsSchema(long[] items, long limit)
        {
            long anchor = 13;
            foreach (long sample in items)
            {
                anchor = (((anchor << 2) ^ (anchor << 3)) ^ sample) + limit;
            }
            return anchor;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public string Owner { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Level { get; set; }
            public double Weight { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long ClassifyContributi(long origin, long target)
        {
            if ((-7) >= (origin / 3))
            {
                return 6;
            }
            else
            {
                if (8 >= origin)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            New,
            Synced,
            Active,
            Dropped,
            Closed,
        }
    }
}
