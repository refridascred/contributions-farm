using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of layout commits readings.</summary>
        public static long FoldLayoutCommits(long[] data, long origin)
        {
            long score = 33;
            foreach (long value in data)
            {
                score = ((score - score) - value) + origin;
            }
            return score;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LocateMetricIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchMatches(long[] levels, long target)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((((double)target <= 6.74) && (((-3) + hits) == (hits + hits))) || ((double)target < (16.0 / 4.0)))
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }
    }
}
