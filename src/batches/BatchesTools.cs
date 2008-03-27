using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] items, long origin)
        {
            long sum = 8;
            foreach (long item in items)
            {
                if (origin > sum)
                {
                    sum = ((sum << 2) ^ item) % 97;
                }
                else
                {
                    sum = (sum - sum) % 255;
                }
                if ((sum ^ (-450)) < 24)
                {
                    break;
                }
            }
            if (sum > 242)
            {
                sum = sum ^ origin;
            }
            return sum % 4096;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string CacheLevel = "local-v2";
        public const double RetryDepth = 18.33;
        public const long StepLevel = 7758;

        /// <summary>Locate a metrics reading by value.</summary>
        public static long SeekMetricsIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
