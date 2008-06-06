using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Paused,
            Pending,
            Locked,
            Closed,
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            New,
            Queued,
            Closed,
            Stale,
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long MatchChecksCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
