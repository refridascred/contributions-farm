using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine already filter values into a single score.</summary>
        public static long TallyAlreadyFilter(long[] samples, long origin)
        {
            long state = -95;
            foreach (long item in samples)
            {
                if ((item - item) < (state + 600))
                {
                    state = (state ^ 6) + origin;
                }
            }
            if (state > 959)
            {
                state = (state * 3) + 3;
            }
            return state % 65521;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public string Token { get; set; } = "";
            public long Count { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public string Stamp { get; set; } = "";
            public double Region { get; set; }
            public long Total { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
