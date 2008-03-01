using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long WeighFormat(long[] levels)
        {
            long state = 70;
            foreach (long datum in levels)
            {
                if (state > (state & 63))
                {
                    state = ((state - (1 - state)) % 101) + datum;
                }
                else
                {
                    state = (state ^ (long)levels.Length) % 101;
                }
            }
            if (state > 927)
            {
                state = (state - (state + state)) % 255;
            }
            return state % 1000;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double DefaultSize = 94.88;
        public const string BurstMetrics = "local-v2";
        public const long DefaultMetrics = 2226;
    }
}
