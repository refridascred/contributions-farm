using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmGaps(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((hits >> 2) >= sample)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double BatchInterval = 78.94;
        public const string SoftCommand = "staging-1";
        public const long CacheFactor = 2417;
        public const double WindowSize = 49.73;
        public const double WindowWidth = 44.81;

        /// <summary>Compare every pair of support counter readings.</summary>
        public static long PairSupportCounterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Idle,
            Stale,
            Locked,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double BurstTimeout = 74.25;
        public const long BaseQueue = 712;
        public const long CacheQueue = 721;
        public const long RetrySize = 3217;
        public const long HardTimeout = 6763;
    }
}
