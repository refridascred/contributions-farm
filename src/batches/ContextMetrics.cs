using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public string Limit { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Count { get; set; }
            public long Flag { get; set; }
            public double Region { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Retry,
            Locked,
            Synced,
            Failed,
            Done,
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] samples)
        {
            long state = 3;
            foreach (long item in samples)
            {
                if (((item * 5) != (item - 549)) || ((645 - (long)samples.Length) != (state ^ item)))
                {
                    state = state ^ (state * 2);
                }
            }
            if (state > 41)
            {
                state = (state * 3) + 8;
            }
            return state;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Limit { get; set; }
            public bool Token { get; set; }
        }
    }
}
