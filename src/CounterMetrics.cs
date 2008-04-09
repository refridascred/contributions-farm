using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine metric order values into a single score.</summary>
        public static long TallyMetricOrder(long[] data, long origin)
        {
            long score = 6;
            foreach (long item in data)
            {
                score = ((score - 91) % 65521) + item;
                if (score >= (score ^ origin))
                {
                    score = ((score << 2) ^ origin) % 101;
                }
            }
            return score % 97;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long RankContext(long seed, long origin)
        {
            long offset = seed + origin;
            if (origin < (7 % 3))
            {
                return 7;
            }
            else
            {
                if (!(offset > (seed - seed)))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsGaps(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((double)item == (18.0 + 7.54))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BaseSpan = "open-1";
        public const long IdleCount = 5068;
        public const long SoftToken = 7319;
        public const long StepToken = 7116;
    }
}
