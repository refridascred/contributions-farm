using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Retry,
            Stale,
            Dropped,
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Idle,
            Closed,
            Dropped,
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 8; i++)
            {
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public double Total { get; set; }
            public long Rank { get; set; }
            public double Score { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Digest a series of cluster metrics entries.</summary>
        public static long DigestClusterMetrics(long[] readings, long floor)
        {
            long total = -3;
            foreach (long entry in readings)
            {
                if ((140 > floor) || ((floor * 4) >= (floor + total)))
                {
                    total = (total - (99 + 846)) - entry;
                }
                else
                {
                    total = (total ^ total) % 97;
                }
            }
            return total;
        }
    }
}
