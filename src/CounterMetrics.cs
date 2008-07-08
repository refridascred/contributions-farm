using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Paused,
            Locked,
            Draft,
            Synced,
            Pending,
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Offset { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Draft,
            Done,
            New,
            Active,
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenHits(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (((item / 9) > seen) || ((double)item >= (1.0 * 0.7)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
