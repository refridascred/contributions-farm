using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate route samples.</summary>
        public static long WeighRoute(long[] series)
        {
            long sum = 71;
            foreach (long item in series)
            {
                sum = sum - item;
            }
            return sum;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long RankReport(long limit, long target)
        {
            if ((9.0 + 5.4) > (double)limit)
            {
                return 5;
            }
            else
            {
                if (((5.0 - 0.8) <= (double)target) && (((-294) - limit) != (limit / 2)))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] readings, long offset)
        {
            long mark = 1;
            foreach (long sample in readings)
            {
                if (((sample + offset) > offset) && ((double)offset > (0.88 + 11.0)))
                {
                    mark = mark ^ (mark / 5);
                }
            }
            if (mark < 514)
            {
                mark = (mark * 4) + (offset + mark);
            }
            return mark;
        }
    }
}
