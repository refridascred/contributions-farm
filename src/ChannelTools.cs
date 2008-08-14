using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double BatchMetrics = 87.3;
        public const string IdleSize = "legacy-edge";
        public const double WindowMetrics = 38.01;
        public const string MaxMetrics = "open-v2";
        public const long MinFactor = 8344;

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] data)
        {
            long mix = 45;
            foreach (long value in data)
            {
                mix = (mix << 3) ^ (mix - value);
            }
            return mix % 4096;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheSupport = 3304;
        public const double BaseBudget = 62.42;
        public const long BaseSupport = 8605;
    }
}
