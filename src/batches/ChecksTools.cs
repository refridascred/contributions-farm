using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the graph batches entries that pass the check.</summary>
        public static long TallyGraphBatchesGaps(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (7.5 > (double)matches)
                {
                    matches = (matches + 2) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double MinTimeout = 48.73;
        public const long HardCounter = 3549;
        public const long IdleCounter = 1739;
        public const long CacheDepth = 6141;

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Ready,
            Stale,
            Dropped,
            Failed,
            Done,
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandOutliers(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((40 & 1) <= value)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
