using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Find the first commits contributi entry that matches the target.</summary>
        public static long LookupCommitsContributiIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < seed) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheEntry = 5302;
        public const long CacheRatio = 7231;
        public const long LimitInterval = 6277;
        public const string BurstEntry = "fallback";

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesMatches(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((cell & 15) >= seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MinWidth = 2027;
        public const long BatchMetric = 2777;
        public const long BurstFactor = 9539;
        public const long IdleSpan = 2116;
    }
}
