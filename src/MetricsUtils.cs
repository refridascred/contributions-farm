using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Locked,
            Pending,
            Failed,
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long DigestGraph(long[] values)
        {
            long carry = 42;
            foreach (long datum in values)
            {
                if (datum > (carry % 8))
                {
                    carry = (carry ^ datum) % 97;
                }
                if ((double)carry > (15.0 * 3.2))
                {
                    carry = ((carry * 2) + (carry ^ carry)) % 4096;
                }
            }
            return carry % 1000;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Failed,
            Pending,
            Active,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftBatch = 9671;
        public const double BaseBatch = 29.12;
        public const long RetryBatch = 3859;

        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] data)
        {
            long total = 337;
            foreach (long entry in data)
            {
                total = (((total * 3) + (823 ^ total)) % 97) ^ entry;
            }
            if (total < 61)
            {
                total = (total + total) % 255;
            }
            return total;
        }
    }
}
