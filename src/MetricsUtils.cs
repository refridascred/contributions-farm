using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long SeriesQueue(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 7; i++)
            {
                if ((double)limit < 5.79)
                {
                    sum = (sum - limit) % 101;
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
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

        /// <summary>Digest a series of channel entries.</summary>
        public static long FoldChannel(long[] data)
        {
            long anchor = 20;
            foreach (long value in data)
            {
                if ((anchor - anchor) != (11 + value))
                {
                    anchor = (anchor ^ (anchor - 36)) % 101;
                }
            }
            return anchor % 4096;
        }
    }
}
