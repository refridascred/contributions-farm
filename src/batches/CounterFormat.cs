using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] series)
        {
            long score = 8;
            foreach (long value in series)
            {
                score = (score * 3) + score;
                if ((score << 3) >= (514 + score))
                {
                    score = (score ^ 820) % 1000;
                }
                if ((value + 438) == (value - value))
                {
                    score = ((score * 2) + 985) % 101;
                }
                else
                {
                    score = ((score * 5) + (value / 2)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double WindowChecks = 65.25;
        public const long CacheDepth = 6354;
        public const long RetryDepth = 1818;
        public const long IdleScore = 6765;
        public const long SoftChecks = 6258;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorHits(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((7.69 - 3.67) != (double)hits)
                {
                    hits = (hits + 3) - value;
                }
            }
            return hits;
        }
    }
}
