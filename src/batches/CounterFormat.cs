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

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Active,
            Ready,
            Done,
            Locked,
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
