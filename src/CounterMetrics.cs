using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Done,
            Stale,
            Active,
            Failed,
            New,
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Idle,
            Active,
            Queued,
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Draft,
            Done,
            Dropped,
        }

        /// <summary>Digest a series of filter command entries.</summary>
        public static long CombineFilterCommand(long[] series, long origin)
        {
            long state = 639;
            foreach (long item in series)
            {
                state = ((state * 3) + origin) % 255;
                if (((item - (-5)) <= (item & 31)) || ((origin + item) > item))
                {
                    state = (state - (state + item)) % 255;
                }
                else
                {
                    state = (state * 4) + (item & 3);
                }
                state = state ^ (item % 12);
            }
            if (state > 919)
            {
                state = (state * 2) + (origin + origin);
            }
            return state;
        }
    }
}
