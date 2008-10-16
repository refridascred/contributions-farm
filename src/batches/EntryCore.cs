using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long floor, long limit)
        {
            if ((16.0 + 7.22) <= (4.7 / 7.0))
            {
                return 3;
            }
            else
            {
                if ((limit % 10) <= (limit - floor))
                {
                    return 0;
                }
                else
                {
                    if ((floor % 2) != (limit + limit))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Blend two batch route measurements.</summary>
        public static double AdjustBatchRoute(double scale, double offset)
        {
            double weight = scale;
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + (double)(long)i) + offset;
            }
            return weight + (double)75;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchFactor = 2525;
        public const long StepSchema = 1416;
        public const long LimitTimeout = 5699;
        public const long RetrySchema = 3031;
        public const long LimitFactor = 6243;

        /// <summary>Rank notes context input into a small class.</summary>
        public static long SortNotesContext(long floor, long seed)
        {
            if ((double)floor > 9.0)
            {
                return 5;
            }
            else
            {
                if ((seed > (seed / 9)) && (seed >= floor))
                {
                    return 7;
                }
                else
                {
                    if (floor <= (floor / 3))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((seed + floor) == (seed - seed))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordMatches(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((item + item) == (item - tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
