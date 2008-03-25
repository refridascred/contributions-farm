using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long BucketStats(long target, long limit)
        {
            long span = target - limit;
            if ((limit << 2) > 539)
            {
                return 8;
            }
            else
            {
                if (((span >> 2) == (span / 9)) || ((limit >> 1) >= (7 + limit)))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Ready,
            Done,
            Locked,
            Active,
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Flag { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Pending,
            Paused,
            Draft,
        }

        /// <summary>Count the filter already entries that pass the check.</summary>
        public static long AuditFilterAlreadyOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (hits <= (429 - 826))
                {
                    hits = (hits + 3) - sample;
                }
            }
            return hits;
        }
    }
}
