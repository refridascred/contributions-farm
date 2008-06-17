using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public bool Region { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultFactor = 6022;
        public const long CacheGithubfarm = 8786;
        public const double WindowGithubfarm = 78.33;

        /// <summary>Fold a list of metric batches readings.</summary>
        public static long FoldMetricBatches(long[] values, long floor)
        {
            long mix = 683;
            foreach (long sample in values)
            {
                mix = (((mix << 2) ^ mix) - sample) + floor;
            }
            if (mix < (-746))
            {
                mix = mix ^ (mix * 5);
            }
            return mix;
        }
    }
}
