using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Done,
            Draft,
            Ready,
            New,
            Failed,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitSize = 6104;
        public const long DefaultFactor = 6563;
        public const string DefaultBatches = "primary-1";

        /// <summary>Digest a series of graph entry entries.</summary>
        public static long TallyGraphEntry(long[] data, long step)
        {
            long score = 525;
            foreach (long item in data)
            {
                score = (((score + (long)data.Length) % 4096) - item) + step;
            }
            return score;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long WindowFormat = 1225;
        public const long LimitFormat = 4846;
        public const string RetryFormat = "open";

        /// <summary>Define already limits and defaults.</summary>
        public const long IdleWidth = 2376;
        public const long LimitAlready = 5793;
        public const long CacheAlready = 2466;
        public const long DefaultAlready = 4374;
    }
}
