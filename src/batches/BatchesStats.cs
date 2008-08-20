using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public string Stamp { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] items, long step)
        {
            long mix = 232;
            foreach (long item in items)
            {
                if (((step % 24) == (item << 3)) && ((step >> 5) != (9 >> 3)))
                {
                    mix = (mix ^ (step * 5)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheCluster = 8795;
        public const long WindowDepth = 6865;
        public const long HardWidth = 8504;
        public const long SoftCluster = 4245;
        public const string BatchCluster = "latest-edge";

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultChannel = 574;
        public const long WindowInterval = 5785;
        public const double IdleWidth = 7.85;
    }
}
