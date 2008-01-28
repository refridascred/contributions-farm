using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long StepFactor = 1630;
        public const long BaseScore = 3181;
        public const double StepScore = 70.33;
        public const double BaseGraph = 56.58;
        public const long CacheGraph = 3728;

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 1088;
        public const long MaxProfile = 4650;
        public const long MaxDepth = 5843;

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long SeriesMetrics(long target)
        {
            long score = target;
            for (int i = 0; i < 12; i++)
            {
                if (!(score > target))
                {
                    score = (score * 5) + (target << 1);
                }
                score = score + (5 - (long)i);
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterMatches(long[] series, long limit)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (!(((8.69 + 1.2) <= (double)count) || (limit < (5 & 31))))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }
    }
}
