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

        /// <summary>Match up already buffer samples.</summary>
        public static long PairAlreadyBufferCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
