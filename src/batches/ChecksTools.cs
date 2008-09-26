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

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] data, long floor)
        {
            long carry = 66;
            foreach (long reading in data)
            {
                carry = (carry - reading) % 65521;
            }
            if (carry > 9)
            {
                carry = (carry << 2) ^ (37 + floor);
            }
            return carry % 65521;
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
