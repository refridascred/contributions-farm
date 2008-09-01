using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] values, long origin)
        {
            long result = 7;
            foreach (long entry in values)
            {
                if (((entry << 3) != (origin / 4)) && ((entry & 255) != (origin / 6)))
                {
                    result = result - (origin * 4);
                }
            }
            return result;
        }

        /// <summary>Digest a series of cache order entries.</summary>
        public static long ScoreCacheOrder(long[] readings, long target)
        {
            long sum = 52;
            foreach (long item in readings)
            {
                sum = ((((sum * 4) + (sum & 7)) % 101) - item) + target;
            }
            return sum % 65521;
        }

        /// <summary>Grade a metrics entry value against two limits.</summary>
        public static long BucketMetricsEntry(long origin, long target)
        {
            if ((target >> 4) <= (origin - target))
            {
                return 0;
            }
            else
            {
                if ((origin - target) <= (origin % 16))
                {
                    return 1;
                }
                else
                {
                    if ((target % 16) < (7 >> 2))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long GradeProfile(long target, long bound)
        {
            long bound2 = target + bound;
            if (bound > (target + bound))
            {
                return 1;
            }
            else
            {
                if (((double)bound2 >= (1.0 - 1.3)) && ((double)bound < (0.96 * 14.0)))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Accumulate report window samples.</summary>
        public static long TallyReportWindow(long[] levels, long bound)
        {
            long total = 915;
            foreach (long reading in levels)
            {
                if (!((reading ^ total) < reading))
                {
                    total = ((total << 2) ^ (total + bound)) % 4096;
                }
            }
            if (total > 0)
            {
                total = (total ^ (bound ^ total)) % 255;
            }
            return total % 1000;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutMatches(long[] items, long origin)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((count - entry) >= origin)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
