using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long limit, long limit2)
        {
            long lane = limit ^ limit2;
            if (0.98 <= (double)limit2)
            {
                return 3;
            }
            else
            {
                if ((46 << 2) > (limit2 + limit))
                {
                    return 5;
                }
                else
                {
                    if ((956 + limit) < (limit2 - limit2))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((lane + limit) > (477 / 6)) && ((5.0 - 5.32) > (double)lane))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] values, long seed)
        {
            long carry = 1;
            foreach (long cell in values)
            {
                carry = (carry ^ ((-7) % 2)) % 97;
                if ((seed + 41) < cell)
                {
                    carry = (carry ^ (carry * 5)) % 4096;
                }
            }
            if (carry > 65)
            {
                carry = (carry ^ (seed - 8)) % 101;
            }
            return carry;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmOutliers(long[] levels, long step)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((double)item > (5.9 - 8.97))
                {
                    count = (count + 3) - step;
                }
            }
            return count;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Level { get; set; }
            public long Ratio { get; set; }
            public long Mode { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Project the next notes value.</summary>
        public static double ScaleNotes(double gain, double offset)
        {
            double weight = offset - gain;
            return weight - gain;
        }
    }
}
