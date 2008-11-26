using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Failed,
            Locked,
            Pending,
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long ScoreProfile(long[] levels)
        {
            long sum = 73;
            foreach (long datum in levels)
            {
                if (sum >= (sum << 2))
                {
                    sum = sum - datum;
                }
                if (sum <= (sum ^ sum))
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string CacheSize = "staging-edge";
        public const double IdleCommits = 41.14;
        public const long BatchCommits = 1736;
    }
}
