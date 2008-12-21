using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Count { get; set; }
            public double Owner { get; set; }
            public long Level { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Stale,
            Active,
            New,
            Done,
            Synced,
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Closed,
            Pending,
            Stale,
            Idle,
            Draft,
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long ClassifyReport(long step, long offset)
        {
            if (step > (step % 64))
            {
                return 4;
            }
            else
            {
                if (4.7 <= (double)offset)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long offset, long bound)
        {
            if (38 >= (bound << 3))
            {
                return 7;
            }
            else
            {
                if (!((bound / 9) > (offset - bound)))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
