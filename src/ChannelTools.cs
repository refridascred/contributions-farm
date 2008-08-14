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

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Offset { get; set; }
            public long Owner { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long DeriveBuffer(long offset)
        {
            long state = offset;
            for (int i = 0; i < 17; i++)
            {
                if (((0.9 - 4.8) != (double)offset) && ((double)(long)i < (double)0))
                {
                    state = (state ^ (state / 3)) % 65521;
                }
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }
    }
}
