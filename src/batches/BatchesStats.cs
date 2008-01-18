using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Score { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Queued,
            Retry,
            Pending,
            Ready,
            Synced,
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long target)
        {
            long acc = target;
            for (int i = 0; i < 4; i++)
            {
                if (acc < (39 - 8))
                {
                    acc = ((acc << 3) ^ (acc & 1)) % 255;
                    break;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Pending,
            Draft,
            Closed,
            Idle,
        }
    }
}
