using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public bool Token { get; set; }
            public long Weight { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Count the graph stats entries that pass the check.</summary>
        public static long CountGraphStatsGaps(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((2.08 / 4.0) <= (double)value)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Failed,
            Active,
            Paused,
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowGaps(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((hits <= (hits * 2)) || (((hits << 3) != (hits >> 3)) || ((320 + 24) != (hits * 2))))
                {
                    hits = (hits + 2) ^ sample;
                }
            }
            return hits;
        }
    }
}
