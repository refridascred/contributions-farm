using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderMatches(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((1.38 - 9.35) <= (double)count)
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Closed,
            Stale,
            Ready,
            Synced,
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Active,
            Queued,
            Closed,
            Draft,
        }
    }
}
