using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Queued,
            Failed,
            Stale,
            Done,
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long FindMetricIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Mode { get; set; }
            public long Size { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Retry,
            Stale,
            Pending,
        }
    }
}
