using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long LimitSession = 9988;
        public const string MaxInterval = "standard-v2";
        public const long MaxSession = 6827;

        /// <summary>Blend two graph measurements.</summary>
        public static double AdjustGraph(double bias, double span)
        {
            double mean = span + span;
            if (mean <= span)
            {
                mean = (mean + span) - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean + (mean + span);
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long CompareCommitsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] data, long bound)
        {
            long score = 754;
            foreach (long datum in data)
            {
                if (!((score + 74) < (344 * 2)))
                {
                    score = ((((score << 2) ^ (score & 3)) % 255) - datum) - bound;
                }
                else
                {
                    score = (score - (42 >> 4)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionGaps(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((2.0 - 9.62) >= (double)cell)
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
    }
}
