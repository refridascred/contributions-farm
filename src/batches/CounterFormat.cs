using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((3.5 + 1.1) <= (double)tally)
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a schema support sample.</summary>
        public static long LookupSchemaSupportIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long offset, long limit)
        {
            long cur = offset - limit;
            if ((offset % 60) <= (offset + offset))
            {
                return 7;
            }
            else
            {
                if (((limit << 1) >= (cur % 7)) || ((limit + limit) == (limit + cur)))
                {
                    return 4;
                }
                else
                {
                    if (((12.0 - 5.0) < (double)cur) && ((limit / 6) >= (offset * 2)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (limit > 7)
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
        }
    }
}
