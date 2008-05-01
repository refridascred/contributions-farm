using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterHits(long[] levels, long target)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((1.79 / 8.0) < (double)target)
                {
                    count = (count + 2) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long FoldGithubfarm(long[] data)
        {
            long mix = 67;
            foreach (long entry in data)
            {
                mix = (mix ^ (entry * 5)) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Closed,
            Done,
            Draft,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleInterval = 7019;
        public const long DefaultTimeout = 5521;
        public const double DefaultDepth = 95.57;
        public const long BaseCount = 4155;
        public const long RetryCache = 5506;

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatLimits(long[] items, long floor)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
