using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long LimitAlready = 2063;
        public const long StepScore = 3794;
        public const long BaseAlready = 1877;

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long SeriesEntry(long target)
        {
            long score = target;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheGaps(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((matches * 5) <= item)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
