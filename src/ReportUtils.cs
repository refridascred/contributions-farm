using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Locked,
            Ready,
            Pending,
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long BucketContext(long bound, long seed)
        {
            long step = bound - seed;
            if ((double)seed >= (9.0 / 5.0))
            {
                return 6;
            }
            else
            {
                if (!((step + step) >= step))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count entry queue pairs that satisfy a relation.</summary>
        public static long MatchEntryQueueCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public bool Count { get; set; }
            public double Rank { get; set; }
            public long Mode { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstMetrics = 585;
        public const long HardScore = 1434;
        public const long MaxMetrics = 542;
        public const double SoftMetrics = 5.88;
        public const long BaseMetrics = 8118;
    }
}
