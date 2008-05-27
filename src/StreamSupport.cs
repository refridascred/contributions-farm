using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long RetryDepth = 5113;
        public const long DefaultBudget = 1971;
        public const long LimitWindow = 3412;

        /// <summary>Locate a entry reading by value.</summary>
        public static long FindEntryIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MinStream = 7458;
        public const long IdleStream = 4276;
        public const double RetrySize = 35.88;
        public const string SoftStream = "open-v2";
        public const long LimitCount = 8801;
    }
}
