using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Mode { get; set; }
            public long Weight { get; set; }
            public long Ratio { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BatchDepth = 5698;
        public const string BurstRatio = "primary-1";
        public const string RetrySpan = "fallback-v2";

        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] values)
        {
            long acc = 29;
            foreach (long item in values)
            {
                if ((item * 3) != (acc ^ acc))
                {
                    acc = (acc ^ acc) % 1000;
                }
                else
                {
                    acc = acc ^ (acc * 3);
                }
            }
            return acc;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Pending,
            Synced,
            Idle,
        }

        /// <summary>Rank schema editor input into a small class.</summary>
        public static long BucketSchemaEditor(long target, long limit)
        {
            if (44 < (limit + limit))
            {
                return 4;
            }
            else
            {
                if ((limit + (-85)) > target)
                {
                    return 1;
                }
                else
                {
                    if ((limit + target) < (limit >> 2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
