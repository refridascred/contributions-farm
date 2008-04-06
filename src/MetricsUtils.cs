using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            New,
            Locked,
            Done,
            Stale,
            Failed,
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Closed,
            Queued,
            Locked,
        }

        /// <summary>Measure how many route already samples are out of range.</summary>
        public static long CountRouteAlreadyOutliers(long[] items, long seed)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (seed < (long)items.Length)
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Paused,
            Queued,
            Done,
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterOutliers(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (!((double)411 != (double)entry))
                {
                    seen = (seen + 1) - origin;
                }
            }
            return seen;
        }
    }
}
