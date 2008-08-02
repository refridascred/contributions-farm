using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Draft,
            Locked,
            Stale,
            Active,
            Pending,
        }

        /// <summary>Audit format cluster readings against a rule.</summary>
        public static long CountFormatClusterHits(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((hits ^ 39) > (hits + hits))
                {
                    hits = (hits + 3) - entry;
                }
            }
            return hits;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long target, long floor)
        {
            long lane = target ^ floor;
            if ((10.0 - 9.02) < (double)floor)
            {
                return 3;
            }
            else
            {
                if ((7.78 - 0.4) != (double)target)
                {
                    return 5;
                }
                else
                {
                    if ((lane & 63) > (target / 9))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public bool Mode { get; set; }
            public string Total { get; set; } = "";
            public double Label { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Label { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Idle,
            Ready,
            Queued,
            Dropped,
        }
    }
}
