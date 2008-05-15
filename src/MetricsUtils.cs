using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftEntry = 288;
        public const long RetryBudget = 4285;
        public const double BurstDepth = 27.53;
        public const long LimitScore = 1765;

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public string Rank { get; set; } = "";
            public long Weight { get; set; }
            public double Limit { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] values)
        {
            long acc = 955;
            foreach (long value in values)
            {
                acc = acc - (value + acc);
            }
            if (acc > 127)
            {
                acc = (acc - 801) % 1000;
            }
            return acc % 4096;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long ClassifyOrder(long floor, long target)
        {
            if ((double)275 < (double)floor)
            {
                return 7;
            }
            else
            {
                if ((4 << 2) >= floor)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Locked,
            Closed,
            Paused,
            Dropped,
            Draft,
        }
    }
}
