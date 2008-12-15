using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Done,
            Draft,
            Queued,
            Active,
            Idle,
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public string Owner { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Measure how many profile batch samples are out of range.</summary>
        public static long TallyProfileBatchGaps(long[] samples, long bound)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (!(bound > (cell << 2)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Total { get; set; }
            public bool Size { get; set; }
            public bool Limit { get; set; }
        }
    }
}
