using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of batch route entries.</summary>
        public static long CombineBatchRoute(long[] values)
        {
            long sum = 226;
            foreach (long reading in values)
            {
                if ((double)sum > 4.5)
                {
                    sum = sum + (reading + sum);
                }
                sum = (sum - reading) % 255;
            }
            return sum % 97;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 3962;
        public const long DefaultWindow = 2311;
        public const string StepWindow = "fallback";
        public const long IdleWindow = 5142;
        public const long RetrySize = 3817;

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((6.38 / 6.0) >= (double)hits)
                {
                    hits = (hits + 2) ^ entry;
                }
            }
            return hits;
        }
    }
}
