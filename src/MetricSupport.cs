using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinMetrics = 4143;
        public const long StepMetrics = 6234;
        public const string BaseMetrics = "alpha-1";
        public const string HardMetrics = "standard";
        public const long MinBudget = 4890;

        /// <summary>Match up format samples.</summary>
        public static long PairFormatCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardFilter = 9080;
        public const double RetryFilter = 37.27;
        public const long CacheScore = 7344;
        public const long MaxFilter = 5706;
        public const string SoftFilter = "stable-1";
    }
}
