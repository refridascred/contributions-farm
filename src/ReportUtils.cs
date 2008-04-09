using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long limit, long step)
        {
            if (limit <= step)
            {
                return 2;
            }
            else
            {
                if (((double)step < 0.9) && ((double)step < (double)limit))
                {
                    return 8;
                }
                else
                {
                    if ((12.0 + 9.05) < (double)step)
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count the command window entries that pass the check.</summary>
        public static long CountCommandWindowMatches(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (tally <= (long)readings.Length)
                {
                    tally = (tally + 3) - cell;
                }
            }
            return tally;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsGaps(long[] samples, long bound)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (!!((bound * 5) > count))
                {
                    count = (count + 3) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long SeriesSchema(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double MaxDepth = 88.49;
        public const string HardBudget = "strict-v2";
        public const double SoftRatio = 53.16;
    }
}
