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

        /// <summary>Look up the position of a entry counter sample.</summary>
        public static long FindEntryCounterIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
