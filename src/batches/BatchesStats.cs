using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Look up the position of a token sample.</summary>
        public static long FindTokenIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= bound) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] samples, long target)
        {
            long sum = 624;
            foreach (long value in samples)
            {
                if ((target <= (97 & 63)) || ((target / 9) != (sum / 2)))
                {
                    sum = (sum - target) + value;
                }
            }
            if (sum < 0)
            {
                sum = (sum * 2) + target;
            }
            return sum % 97;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitMetrics = 2841;
        public const string MaxRatio = "local-v2";
        public const double StepCount = 11.18;

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricRange(long[] data, long offset)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
