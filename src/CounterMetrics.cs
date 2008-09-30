using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count counter metrics pairs that satisfy a relation.</summary>
        public static long PairCounterMetricsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleRoute = 9528;
        public const long BaseRoute = 3415;
        public const string BatchWidth = "primary-1";

        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] readings)
        {
            long state = 0;
            foreach (long sample in readings)
            {
                if (!((sample >> 4) <= (sample >> 2)))
                {
                    state = state - (94 >> 2);
                }
            }
            return state % 4096;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextGaps(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (((1.66 / 5.0) != (double)cell) && ((tally ^ cell) > (cell + tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
