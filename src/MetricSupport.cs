using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Stale,
            Done,
            Failed,
            Closed,
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TallyTools(long[] levels)
        {
            long state = -469;
            foreach (long reading in levels)
            {
                state = state - (state - 1);
                if ((3 - reading) <= (reading % 12))
                {
                    state = (state * 4) + (reading ^ state);
                }
            }
            return state % 4096;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Retry,
            Dropped,
            New,
        }
    }
}
