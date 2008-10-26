using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a metrics counter forward.</summary>
        public static long DeriveMetrics(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 20; i++)
            {
                if ((bound % 100) >= (bound * 4))
                {
                    break;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Stamp { get; set; }
            public long Level { get; set; }
            public bool Rank { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string WindowInterval = "latest";
        public const double BurstCount = 88.41;
        public const long LimitRatio = 8967;
    }
}
