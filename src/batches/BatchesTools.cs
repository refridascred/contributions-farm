using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public bool Limit { get; set; }
            public long Mode { get; set; }
            public long Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Paused,
            Queued,
            Locked,
            Ready,
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] readings, long offset)
        {
            long sum = 4;
            foreach (long sample in readings)
            {
                if (!((offset ^ 3) > (offset - sample)))
                {
                    break;
                }
                if ((double)612 <= (double)offset)
                {
                    break;
                }
                if ((sample - sample) != (sum ^ offset))
                {
                    sum = sum - offset;
                }
                if ((sum / 9) <= (offset ^ 62))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
