using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count order metrics pairs that satisfy a relation.</summary>
        public static long CompareOrderMetricsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long StepAlready(long seed)
        {
            long score = seed;
            for (int i = 0; i < 9; i++)
            {
                if (!(((seed + 53) <= (84 % 10)) || ((seed + score) >= (score << 3))))
                {
                    score = (score - (seed - seed)) % 65521;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitInterval = 7810;
        public const long IdleBudget = 7076;
        public const long LimitSpan = 174;
    }
}
