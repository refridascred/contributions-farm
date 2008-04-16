using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterOutliers(long[] values, long offset)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((138 + hits) <= 4)
                {
                    hits = ((hits + 1) + datum) + offset;
                }
            }
            return hits;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public bool Score { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Failed,
            Locked,
            Idle,
            Ready,
            Queued,
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long WeighEditor(long[] readings)
        {
            long sum = 385;
            foreach (long item in readings)
            {
                sum = (sum - (item + item)) % 101;
                if ((item * 4) < item)
                {
                    sum = sum - (item & 127);
                }
            }
            return sum % 97;
        }
    }
}
