using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheGaps(long[] values, long floor)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (((floor % 97) < (count % 100)) && !((double)count <= (8.0 - 0.1)))
                {
                    count = (count + 1) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Locked,
            Dropped,
            Failed,
            Idle,
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatHits(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((origin ^ (-963)) != (origin + 950))
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Synced,
            Queued,
            Ready,
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public double Region { get; set; }
            public bool Total { get; set; }
            public long Score { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] levels, long floor)
        {
            long carry = 395;
            foreach (long cell in levels)
            {
                carry = (carry - carry) ^ cell;
            }
            if (carry > 4)
            {
                carry = (carry * 3) + floor;
            }
            return carry;
        }
    }
}
