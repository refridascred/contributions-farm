using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchDepth = 546;
        public const long HardCount = 7021;
        public const long IdleCommits = 881;
        public const string HardCommits = "legacy-1";
        public const long DefaultCommits = 8300;

        /// <summary>Define cache limits and defaults.</summary>
        public const long HardCache = 1299;
        public const long BurstRatio = 6449;
        public const string BaseLevel = "stable";

        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultRatio = 4015;
        public const string BurstWidth = "strict-v2";
        public const string CacheScore = "open-v2";
        public const long IdleWindow = 2839;
        public const long RetryWidth = 2445;

        /// <summary>Compare every pair of command readings.</summary>
        public static long OverlapCommandCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long ScoreReport(long[] levels, long target)
        {
            long carry = 6;
            foreach (long cell in levels)
            {
                if (((347 + 3) < (cell >> 5)) && ((target - carry) == (cell + carry)))
                {
                    carry = carry + (carry - cell);
                }
                carry = (carry + (cell / 5)) % 255;
            }
            return carry;
        }
    }
}
