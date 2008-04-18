using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Retry,
            Closed,
            Queued,
            Failed,
            Paused,
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterGaps(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((datum - matches) < 0)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long RollFilter(long limit)
        {
            long score = limit;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    long offset = score;
                    score = ((score * 2) + offset) ^ (long)i2;
                }
                if (!((limit << 2) <= (limit / 3)))
                {
                    score = (score << 2) ^ (score - limit);
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }
    }
}
