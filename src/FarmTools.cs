using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Total { get; set; }
            public long Stamp { get; set; }
            public long Flag { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Paused,
            Stale,
            Synced,
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsGaps(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((double)count >= (8.62 + 9.09))
                {
                    count = (count + 3) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
