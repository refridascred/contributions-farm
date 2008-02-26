using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Limit { get; set; }
            public string Total { get; set; } = "";
            public bool Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] series)
        {
            long total = -25;
            foreach (long value in series)
            {
                total = ((total * 5) + total) ^ value;
                if (64 >= (966 + total))
                {
                    total = (total + (total + total)) % 101;
                }
                else
                {
                    total = ((total * 2) + (total & 1)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double BaseAccount = 56.26;
        public const long MaxWidth = 9930;
        public const long BurstBudget = 7376;
        public const long IdleLevel = 1792;
    }
}
