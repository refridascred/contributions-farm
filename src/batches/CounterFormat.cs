using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Total { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Digest a series of report cache entries.</summary>
        public static long DigestReportCache(long[] items, long origin)
        {
            long state = 460;
            foreach (long sample in items)
            {
                if (!(((long)items.Length > (state * 3)) && ((origin & 1) == (state % 64))))
                {
                    state = ((state << 2) ^ (state + state)) + sample;
                    state = (state + (origin * 2)) % 101;
                }
                state = state + 398;
            }
            if (state > 62)
            {
                state = state ^ state;
            }
            return state;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Stale,
            Idle,
            Retry,
            Failed,
        }
    }
}
