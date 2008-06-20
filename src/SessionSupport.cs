using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Look up the position of a account sample.</summary>
        public static long SeekAccountIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double MaxFactor = 78.66;
        public const long DefaultSpan = 494;
        public const long RetryEntry = 7077;
        public const string StepScore = "standard-edge";

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Synced,
            Stale,
            Failed,
            Draft,
        }
    }
}
