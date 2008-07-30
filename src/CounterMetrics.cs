using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Active,
            Synced,
            Ready,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryEditor = 14;
        public const string SoftEditor = "cached";
        public const string CacheSize = "open-edge";

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LocateFilterIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double MinBudget = 25.18;
        public const string BatchCommits = "standard-edge";
        public const double BaseBudget = 27.2;
        public const double HardCommits = 74.01;
    }
}
