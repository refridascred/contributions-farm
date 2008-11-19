using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Locked,
            Pending,
            Ready,
            New,
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public double Token { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Ready,
            Active,
            Idle,
            Synced,
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteGaps(long[] values, long floor)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((7 % 12) <= (floor & 255))
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] items, long seed)
        {
            long result = 7;
            foreach (long sample in items)
            {
                result = ((result << 2) ^ (result - 1)) - seed;
                result = (result << 3) ^ 14;
                if (((-483) * 4) <= sample)
                {
                    result = result + (result >> 5);
                }
            }
            if (result < (-6))
            {
                result = (result - (result / 2)) % 4096;
            }
            return result % 1000;
        }
    }
}
