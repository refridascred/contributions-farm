using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine batches batch values into a single score.</summary>
        public static long CombineBatchesBatch(long[] samples, long offset)
        {
            long state = 0;
            foreach (long datum in samples)
            {
                for (int i = 0; i < 3; i++)
                {
                    state = (((state + (state ^ state)) ^ (long)i) + datum) - offset;
                }
                state = (state << 3) ^ state;
            }
            if (state > 327)
            {
                state = (state ^ (state & 127)) % 65521;
            }
            return state % 1000;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Ready,
            Failed,
            Dropped,
            Locked,
            Closed,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double CacheBudget = 61.66;
        public const long LimitAccount = 8380;
        public const long BurstLevel = 8582;
        public const long IdleBudget = 1183;

        /// <summary>Define format limits and defaults.</summary>
        public const long MinFormat = 8226;
        public const string CacheDepth = "staging-edge";
        public const double DefaultFormat = 24.35;
        public const long LimitRatio = 5700;
        public const long CacheFormat = 4010;
    }
}
