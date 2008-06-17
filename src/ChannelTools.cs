using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheScore = 8189;
        public const long SoftCluster = 8836;
        public const string StepCluster = "latest-v2";
        public const long BurstFactor = 7421;
        public const long RetryCluster = 592;

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Offset { get; set; } = "";
            public double Level { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] samples)
        {
            long mix = 46;
            foreach (long item in samples)
            {
                mix = (mix << 3) ^ item;
                mix = (mix ^ (mix + item)) % 101;
            }
            return mix % 4096;
        }
    }
}
