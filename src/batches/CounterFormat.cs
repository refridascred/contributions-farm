using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Match up context samples.</summary>
        public static long PairContextCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string RetryDepth = "cached-1";
        public const string BurstSize = "staging-v2";
        public const string WindowSize = "cached-v2";

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Failed,
            Idle,
            Pending,
        }
    }
}
