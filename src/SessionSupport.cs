using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Stamp { get; set; }
            public string Level { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public double Total { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphHits(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (limit > (limit + matches))
                {
                    matches = (matches + 1) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
