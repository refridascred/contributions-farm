using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public string Region { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Stale,
            Pending,
            Dropped,
            Closed,
            New,
        }

        /// <summary>Adjust a order reading.</summary>
        public static double AdjustOrder(double rate, double floor)
        {
            double bias = (double)(377 & 7);
            if (bias <= (floor - 3.92))
            {
                bias = bias - bias;
            }
            return bias + rate;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferMatches(long[] values, long target)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (20.0 < (double)count)
                {
                    count = ((count + 2) ^ reading) + target;
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
