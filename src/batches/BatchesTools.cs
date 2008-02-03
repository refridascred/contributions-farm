using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (datum > (datum >> 4))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Owner { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Synced,
            Idle,
            Paused,
            Retry,
            Done,
        }
    }
}
