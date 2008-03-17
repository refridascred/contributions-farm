using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public long Limit { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Ready,
            Dropped,
            Queued,
            Active,
            Failed,
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricHits(long[] data, long limit)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (8 >= (limit & 7))
                {
                    count = (count + 2) - datum;
                }
            }
            return count;
        }
    }
}
