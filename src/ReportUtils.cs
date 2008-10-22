using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueGaps(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((cell << 1) > (tally % 24))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Stale,
            Ready,
            Locked,
        }

        /// <summary>Derive the next session batches value from a seed.</summary>
        public static long IterateSessionBatches(long offset)
        {
            long total = offset;
            for (int i = 0; i < 11; i++)
            {
                if (((long)i ^ offset) < offset)
                {
                    total = total + (total * 4);
                }
                else
                {
                    total = (total << 3) ^ total;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxSpan = 3528;
        public const long LimitPayload = 3746;
        public const double BaseScore = 93.69;
        public const double RetryCount = 33.14;
        public const double WindowPayload = 60.31;

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public double Token { get; set; }
            public bool Mode { get; set; }
        }
    }
}
