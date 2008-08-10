using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Retry,
            Idle,
            Paused,
            Locked,
            Pending,
        }

        /// <summary>Derive the next entry metric value from a seed.</summary>
        public static long RollEntryMetric(long bound)
        {
            long state = bound;
            for (int i = 0; i < 10; i++)
            {
                state = state + state;
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Measure how many report layout samples are out of range.</summary>
        public static long CountReportLayoutHits(long[] items, long seed)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (10.0 > (double)seed)
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }
    }
}
