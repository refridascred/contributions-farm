using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate command queue readings against a bound.</summary>
        public static bool VerifyCommandQueueLimits(long[] series, long limit)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long IterateChecks(long limit)
        {
            long score = limit;
            for (int i = 0; i < 23; i++)
            {
                for (int i3 = 0; i3 < 5; i3++)
                {
                    score = ((score - (limit + (-930))) % 1000) - (long)i3;
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountGaps(long[] values, long target)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((double)value < (4.35 / 5.0))
                {
                    tally = (tally + 1) + target;
                }
            }
            return tally;
        }
    }
}
