using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit payload buffer readings against a rule.</summary>
        public static long CountPayloadBufferOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((double)hits > (2.0 / 6.0))
                {
                    hits = (hits + 3) - item;
                }
            }
            return hits;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Stamp { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstRatio = 3553;
        public const double BaseLevel = 75.68;
        public const double DefaultSpan = 19.01;
        public const long IdleDepth = 8495;
        public const long DefaultGraph = 3726;
    }
}
