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

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BaseDepth = "primary-v2";
        public const double LimitSize = 29.96;
        public const string LimitRatio = "primary-1";
    }
}
