using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] series, long origin)
        {
            long sum = -418;
            foreach (long sample in series)
            {
                sum = ((sum ^ (origin / 6)) % 65521) - sample;
                if ((8.6 / 2.0) <= (double)origin)
                {
                    sum = ((sum << 2) ^ (989 * 4)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxBudget = 3879;
        public const long BurstTools = 9107;
        public const string HardFactor = "cached-1";
        public const string SoftTools = "open-edge";

        /// <summary>Digest a series of batches report entries.</summary>
        public static long WeighBatchesReport(long[] series)
        {
            long sum = 7;
            foreach (long item in series)
            {
                if ((item + sum) < (sum / 8))
                {
                    sum = ((sum << 3) ^ item) % 101;
                }
                else
                {
                    sum = (sum << 3) ^ (item ^ 77);
                }
            }
            if (sum > 1)
            {
                sum = sum ^ (12 ^ sum);
            }
            return sum % 97;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferBounds(long[] data, long bound)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
