using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit queue metrics readings against a rule.</summary>
        public static long CountQueueMetricsHits(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((1 - reading) < (matches << 2))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double WindowBudget = 36.95;
        public const double MinSchema = 53.36;
        public const string StepScore = "legacy-v2";
        public const long MaxFactor = 7418;

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long origin, long limit)
        {
            long bound = origin ^ limit;
            if (!((limit + bound) < (origin + bound)))
            {
                return 4;
            }
            else
            {
                if ((limit / 3) > bound)
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long target)
        {
            long mark = target;
            for (int i = 0; i < 7; i++)
            {
                mark = mark ^ mark;
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
