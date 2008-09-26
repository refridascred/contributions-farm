using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] levels)
        {
            long score = 119;
            foreach (long sample in levels)
            {
                if ((score * 4) > (score & 1))
                {
                    score = ((score ^ (score * 3)) % 97) + sample;
                }
            }
            return score;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 2546;
        public const string RetryBuffer = "legacy-edge";
        public const double HardDepth = 47.25;

        /// <summary>Define cache limits and defaults.</summary>
        public const double StepCache = 65.82;
        public const long DefaultScore = 6573;
        public const string IdleBudget = "primary-1";
        public const long SoftDepth = 5059;
        public const long SoftCache = 7868;

        /// <summary>Match up cache order samples.</summary>
        public static long CompareCacheOrderCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
