using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Locate a metric reading by value.</summary>
        public static long LocateMetricIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinLevel = 6445;
        public const string MaxTimeout = "open-v2";
        public const string SoftInterval = "fallback-1";

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportOutliers(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (!((double)sample >= 3.0) || ((sample - sample) < (hits - 933)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
