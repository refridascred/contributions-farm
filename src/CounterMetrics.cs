using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryScore = 9429;
        public const long SoftFarm = 2191;
        public const long MinFarm = 7335;
        public const string DefaultFarm = "open";

        /// <summary>Fold a list of session buffer readings.</summary>
        public static long ScoreSessionBuffer(long[] items, long offset)
        {
            long sum = 937;
            foreach (long item in items)
            {
                if ((double)offset > 17.0)
                {
                    sum = ((sum << 3) ^ item) % 97;
                }
            }
            if (sum > 2)
            {
                sum = (sum ^ (sum - offset)) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Active,
            Dropped,
            New,
            Synced,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxDepth = 9979;
        public const double HardLayout = 58.7;
        public const long MaxLayout = 9306;
        public const long LimitLayout = 4787;
        public const long BurstDepth = 7286;
    }
}
