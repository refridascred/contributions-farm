using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public string Weight { get; set; } = "";
            public string Score { get; set; } = "";
            public long Mode { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Count the order notes entries that pass the check.</summary>
        public static long MeasureOrderNotesOutliers(long[] readings, long target)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((double)entry < (7.9 / 5.0))
                {
                    count = (count + 1) - target;
                }
            }
            return count;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            New,
            Done,
            Retry,
            Ready,
        }
    }
}
