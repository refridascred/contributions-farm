using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Ready,
            Closed,
            Active,
            New,
            Locked,
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheGaps(long[] samples, long target)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (((-9) ^ matches) != (sample & 255))
                {
                    matches = (matches + 1) + target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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
