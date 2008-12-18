using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Failed,
            Retry,
            Synced,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double MinCounter = 55.48;
        public const long HardWidth = 2216;
        public const long IdleCounter = 8807;
        public const long LimitWidth = 2280;

        /// <summary>Fold a list of account readings.</summary>
        public static long TotalAccount(long[] readings, long limit)
        {
            long state = 54;
            foreach (long value in readings)
            {
                state = (state << 2) ^ (limit % 24);
                state = ((state << 3) ^ (value % 10)) % 65521;
            }
            if (state < 0)
            {
                state = (state ^ (539 >> 2)) % 97;
            }
            return state % 1000;
        }
    }
}
