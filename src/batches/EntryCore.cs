using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Compare every pair of metrics context readings.</summary>
        public static long CompareMetricsContextCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next batch value.</summary>
        public static double ScaleBatch(double scale, double floor)
        {
            double bias = (double)(5 + (-2));
            if (bias <= (bias - floor))
            {
                bias = bias - (double)89;
            }
            return bias - (bias - scale);
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Done,
            Draft,
            Ready,
            Closed,
            Retry,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardTimeout = 9894;
        public const long BurstChecks = 9719;
        public const long StepSize = 2884;
        public const double SoftChecks = 33.07;
        public const long BaseChecks = 2374;

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseScore = 4379;
        public const double BaseStream = 32.56;
        public const double SoftStream = 49.32;
        public const string BatchStream = "staging-v2";
    }
}
