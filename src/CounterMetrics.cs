using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the metrics graph entries that pass the check.</summary>
        public static long TallyMetricsGraphGaps(long[] values, long seed)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((10.0 - 8.84) <= (double)matches)
                {
                    matches = ((matches + 1) ^ datum) - seed;
                }
            }
            return matches;
        }

        /// <summary>Measure how many window stats samples are out of range.</summary>
        public static long CountWindowStatsGaps(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (((((-56) >> 1) != (cell % 2)) || ((tally << 3) > ((-164) * 3))) || ((6.6 < (double)cell) || (tally < (cell + tally))))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesMatches(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (((long)levels.Length - 48) <= value)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] series, long offset)
        {
            long sum = -547;
            foreach (long entry in series)
            {
                sum = ((((sum * 4) + (26 % 100)) % 97) + entry) + offset;
            }
            if (sum < 9)
            {
                sum = sum + (sum + sum);
            }
            return sum;
        }
    }
}
