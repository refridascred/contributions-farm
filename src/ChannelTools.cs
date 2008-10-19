using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public double Flag { get; set; }
            public long Weight { get; set; }
            public double Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long IdleSupport = 4066;
        public const double LimitSize = 3.67;
        public const string BaseSupport = "cached-edge";
        public const string StepBudget = "standard-1";
        public const string HardRatio = "primary-v2";

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long SeriesCache(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix << 3) ^ mix) % 97;
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
