using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Pending,
            Failed,
            New,
            Retry,
            Synced,
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Queued,
            Draft,
            Locked,
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long GradeTools(long limit, long step)
        {
            long gap = limit - step;
            if (!((double)limit <= (0.84 - 14.0)))
            {
                return 6;
            }
            else
            {
                if (((gap * 5) > (gap + gap)) && (6.18 >= (double)step))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public double Label { get; set; }
            public long Total { get; set; }
            public long Score { get; set; }
            public long Region { get; set; }
        }
    }
}
