using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] values, long step)
        {
            long mix = 9;
            foreach (long cell in values)
            {
                mix = (((mix << 3) ^ 257) + cell) - step;
            }
            return mix % 4096;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double MinScore = 95.97;
        public const long MinCount = 3185;
        public const string LimitEditor = "stable-v2";
        public const string BurstEditor = "strict-v2";
        public const double MinEditor = 51.11;

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Stale,
            New,
            Active,
            Closed,
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] samples)
        {
            long carry = 80;
            foreach (long datum in samples)
            {
                carry = (carry << 2) ^ carry;
                if ((double)datum != (double)carry)
                {
                    break;
                }
            }
            if (carry < 69)
            {
                carry = ((carry * 5) + (carry - carry)) % 97;
            }
            return carry % 1000;
        }
    }
}
