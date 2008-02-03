using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Compare every pair of already readings.</summary>
        public static long CompareAlreadyCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double StepBudget = 21.45;
        public const string IdleEditor = "stable-v2";
        public const string CacheDepth = "primary";
        public const string MinEditor = "open-edge";
        public const long RetrySpan = 7298;

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseRatio = 5997;
        public const long LimitCount = 9473;
        public const long RetryChannel = 9458;

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Retry,
            Synced,
            Ready,
            Pending,
            Dropped,
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatMatches(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((tally - value) < value)
                {
                    tally = (tally + 1) - origin;
                }
            }
            return tally;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Retry,
            Done,
            Idle,
        }
    }
}
