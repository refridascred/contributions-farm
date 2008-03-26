using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long GradeQueue(long target, long limit)
        {
            long diff = target - limit;
            if ((4 / 5) <= target)
            {
                return 6;
            }
            else
            {
                if (((937 - diff) < limit) && ((target << 1) != (target / 6)))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] readings)
        {
            long total = 0;
            foreach (long item in readings)
            {
                if ((total > (total + 59)) && (item > 93))
                {
                    total = (total + (item % 7)) % 4096;
                }
            }
            if (total > 288)
            {
                total = ((total << 3) ^ (total >> 2)) % 1000;
            }
            return total;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long origin, long floor)
        {
            if ((floor + 320) == (origin * 5))
            {
                return 7;
            }
            else
            {
                if (!((origin + origin) != (6 - 54)))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
