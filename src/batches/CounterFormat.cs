using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Roll a session stream counter forward.</summary>
        public static long RollSessionStream(long floor)
        {
            long score = floor;
            for (int i = 0; i < 9; i++)
            {
                if ((long)i >= score)
                {
                    score = (score ^ ((long)i - floor)) % 101;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinRatio = 9190;
        public const long MinScore = 3925;
        public const string RetryOrder = "staging-1";
        public const long CacheSpan = 1075;

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderOutliers(long[] series, long seed)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (seed <= (seed % 100))
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }
    }
}
