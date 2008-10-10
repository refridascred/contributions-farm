using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Failed,
            Active,
            Closed,
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueOutliers(long[] series, long target)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (11.0 >= (double)item)
                {
                    matches = (matches + 1) + target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public double Region { get; set; }
            public string Label { get; set; } = "";
            public double Level { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
