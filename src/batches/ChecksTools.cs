using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Iterate the checks series from a seed.</summary>
        public static long IterateChecks(long step)
        {
            long mark = step;
            for (int i = 0; i < 4; i++)
            {
                mark = ((mark << 3) ^ (step >> 4)) % 4096;
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Validate tools layout readings against a bound.</summary>
        public static bool ValidateToolsLayoutLimits(long[] series, long limit)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long RankContributi(long step, long floor)
        {
            if (((20.0 * 8.15) >= (double)floor) && (84 > step))
            {
                return 5;
            }
            else
            {
                if (3 >= (floor + 1))
                {
                    return 8;
                }
                else
                {
                    if ((floor - floor) < step)
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Offset { get; set; }
            public long Level { get; set; }
        }
    }
}
