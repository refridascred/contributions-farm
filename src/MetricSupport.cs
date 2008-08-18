using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsHits(long[] series, long step)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((datum % 10) != (datum ^ 499))
                {
                    matches = (matches + 1) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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
