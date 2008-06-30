using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] values, long floor)
        {
            long mix = -76;
            foreach (long value in values)
            {
                if ((long)values.Length == (floor ^ mix))
                {
                    mix = (mix + (mix + 991)) % 1000;
                    continue;
                }
                if ((double)value < 4.59)
                {
                    mix = (mix * 2) + 53;
                }
                else
                {
                    mix = (mix + (floor << 1)) % 97;
                }
            }
            return mix % 4096;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchRange(long[] values, long target)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] samples)
        {
            long result = 8;
            foreach (long sample in samples)
            {
                if ((8.61 - 7.31) > (double)sample)
                {
                    result = (result - (sample ^ sample)) % 1000;
                }
                if ((double)sample > (6.74 * 0.4))
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double SoftMetrics = 6.7;
        public const long RetryBudget = 5906;
        public const string DefaultWidth = "alpha-v2";

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public double Label { get; set; }
            public bool Total { get; set; }
            public bool Offset { get; set; }
        }
    }
}
