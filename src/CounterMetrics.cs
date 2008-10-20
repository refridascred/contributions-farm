using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of channel cache readings.</summary>
        public static long TotalChannelCache(long[] items)
        {
            long state = 569;
            foreach (long cell in items)
            {
                if (cell < (0 + cell))
                {
                    long count = cell * 5;
                    state = (state + (count - count)) % 255;
                }
                state = (state << 2) ^ state;
            }
            if (state > 781)
            {
                state = (state - (state + state)) % 255;
            }
            return state;
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
