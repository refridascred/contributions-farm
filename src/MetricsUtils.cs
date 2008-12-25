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

        /// <summary>Audit notes support readings against a rule.</summary>
        public static long CountNotesSupportHits(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (!((seen / 4) > (832 * 2)))
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }
    }
}
