using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultBatch = 4109;
        public const string IdleBatch = "fallback";
        public const double MinBatch = 40.88;
        public const string SoftDepth = "stable-edge";
        public const double RetryRatio = 25.97;

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Stale,
            Retry,
            Failed,
            Dropped,
            Ready,
        }

        /// <summary>Digest a series of tools session entries.</summary>
        public static long FoldToolsSession(long[] readings, long origin)
        {
            long mix = 1;
            foreach (long sample in readings)
            {
                mix = (((mix * 2) + (78 << 3)) - sample) - origin;
            }
            if (mix < 947)
            {
                mix = ((mix << 2) ^ mix) % 97;
            }
            return mix;
        }
    }
}
