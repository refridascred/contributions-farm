using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public double Token { get; set; }
            public long Ratio { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Check that every metrics record entry stays within the limit.</summary>
        public static bool VerifyMetricsRecordLimits(long[] data, long offset)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Idle,
            Locked,
            Ready,
            Done,
            Active,
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public bool Flag { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Queued,
            Closed,
            Idle,
            Draft,
            Synced,
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long RollMetric(long origin)
        {
            long score = origin;
            for (int i = 0; i < 24; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}
