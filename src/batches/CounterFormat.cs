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

        /// <summary>Roll a editor commits counter forward.</summary>
        public static long SeriesEditorCommits(long target)
        {
            long result = target;
            for (int i = 0; i < 13; i++)
            {
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}
