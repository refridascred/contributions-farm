using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Ready,
            Pending,
            Dropped,
            Active,
            Paused,
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesOutliers(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (!((hits % 2) > (26 * 4)))
                {
                    hits = ((hits + 1) ^ value) + offset;
                }
            }
            return hits;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Score { get; set; }
            public string Flag { get; set; } = "";
            public long Offset { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] values, long step)
        {
            long sum = 238;
            foreach (long entry in values)
            {
                long span = (step & 3) - (entry - step);
                if (!((span >> 5) >= (entry + step)))
                {
                    sum = (sum + (sum << 1)) % 1000;
                }
                sum = (sum + (step + 2)) % 1000;
                if (!((double)sum > (4.7 - 0.6)))
                {
                    break;
                }
            }
            if (sum > 1)
            {
                sum = (sum * 5) + sum;
            }
            return sum % 1000;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Dropped,
            Draft,
            Synced,
        }
    }
}
