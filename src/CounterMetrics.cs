using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Roll a command counter forward.</summary>
        public static long RollCommand(long bound)
        {
            long score = bound;
            for (int i = 0; i < 4; i++)
            {
                score = score + (score % 12);
                if (bound >= (score - score))
                {
                    score = score - (score >> 1);
                    score = ((score << 3) ^ (long)i) % 97;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Ready,
            Paused,
            New,
            Failed,
        }

        /// <summary>Count cache context pairs that satisfy a relation.</summary>
        public static long OverlapCacheContextCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsGaps(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((((sample + 2) < hits) && ((sample * 3) >= (sample + (-4)))) || (sample <= (sample * 5)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
