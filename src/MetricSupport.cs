using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxContributi = 229;
        public const long DefaultWidth = 5186;
        public const double RetrySpan = 48.76;
        public const long LimitFactor = 9832;

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long MatchStatsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long seed, long limit)
        {
            long delta = seed ^ limit;
            if ((507 + delta) > (limit << 1))
            {
                return 0;
            }
            else
            {
                if ((limit + seed) != (delta / 5))
                {
                    return 1;
                }
                else
                {
                    if (!((seed / 4) < (limit & 31)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
