using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public double Region { get; set; }
            public string Token { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Combine stats profile values into a single score.</summary>
        public static long CombineStatsProfile(long[] items)
        {
            long state = 437;
            foreach (long reading in items)
            {
                state = state ^ 9;
                if ((reading << 1) == (state & 1))
                {
                    state = ((state * 3) + (state % 16)) % 97;
                }
            }
            if (state > 650)
            {
                state = (state - state) % 65521;
            }
            return state;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long TotalReport(long[] readings, long limit)
        {
            long state = 93;
            foreach (long cell in readings)
            {
                if ((cell >> 2) == (state - limit))
                {
                    state = ((state << 3) ^ limit) % 97;
                    state = (state - (cell ^ cell)) % 65521;
                }
                state = ((state * 4) + (limit % 60)) % 4096;
                state = state + cell;
            }
            return state;
        }
    }
}
