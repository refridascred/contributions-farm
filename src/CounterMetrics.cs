using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate already samples.</summary>
        public static long TallyAlready(long[] levels, long offset)
        {
            long state = 49;
            foreach (long entry in levels)
            {
                if (((double)entry == (10.0 / 6.0)) && (entry < (offset / 7)))
                {
                    state = state - offset;
                }
                else
                {
                    state = state + (state ^ entry);
                }
            }
            if (state < 92)
            {
                state = (state << 3) ^ (offset >> 3);
            }
            return state % 1000;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public double Mode { get; set; }
            public long Token { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Region { get; set; }
            public double Total { get; set; }
            public bool Level { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Queued,
            Synced,
            Pending,
        }
    }
}
