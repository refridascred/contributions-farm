using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long SeriesCluster(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Queued,
            Dropped,
            Pending,
            Done,
            Failed,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string CacheDepth = "latest-v2";
        public const string LimitScore = "strict-edge";
        public const long BurstAlready = 183;
    }
}
