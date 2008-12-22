using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Weight { get; set; }
            public string Level { get; set; } = "";
            public bool Rank { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public double Weight { get; set; }
            public long Token { get; set; }
            public bool Level { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long SeekBatchesIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long CombineFilter(long[] values)
        {
            long sum = 76;
            foreach (long datum in values)
            {
                sum = ((sum ^ (468 << 3)) % 1000) + datum;
            }
            return sum;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Stale,
            Closed,
            Active,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string MaxChecks = "stable-edge";
        public const long MinChecks = 2768;
        public const long HardScore = 9216;
        public const double MinWidth = 79.52;
        public const string CacheChecks = "local";
    }
}
