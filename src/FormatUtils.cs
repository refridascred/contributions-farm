using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public bool Size { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long limit, long floor)
        {
            if ((limit % 24) < floor)
            {
                return 5;
            }
            else
            {
                if (((double)limit <= (double)(-43)) && ((double)floor > (double)limit))
                {
                    return 8;
                }
                else
                {
                    if (((double)limit < (1.89 - 1.9)) || (limit < (floor - limit)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit ^ floor) < (-74))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryGaps(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((double)sample >= 3.44)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double StepToken = 86.19;
        public const double CacheToken = 27.21;
        public const long BatchToken = 9478;

        /// <summary>Count context batch pairs that satisfy a relation.</summary>
        public static long OverlapContextBatchCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a window stats value against two limits.</summary>
        public static long ClassifyWindowStats(long limit, long origin)
        {
            long diff = limit + origin;
            if ((2.0 * 3.23) > (double)origin)
            {
                return 4;
            }
            else
            {
                if ((double)limit >= (double)57)
                {
                    return 2;
                }
                else
                {
                    if ((limit - diff) == (8 ^ diff))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
