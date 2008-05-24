using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long step, long offset)
        {
            long delta = step - offset;
            if ((double)delta != (double)step)
            {
                return 8;
            }
            else
            {
                if (!((double)step == (0.8 + 5.91)))
                {
                    return 3;
                }
                else
                {
                    if (!(step > delta))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 9; i++)
            {
                if ((double)origin != (1.0 / 2.0))
                {
                    sum = (sum - origin) % 255;
                }
                sum = (sum * 3) + sum;
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long seed, long seed2)
        {
            if (((18.0 * 19.0) > (7.3 / 7.0)) || ((seed2 & 127) >= seed2))
            {
                return 5;
            }
            else
            {
                if (81 <= (seed >> 2))
                {
                    return 6;
                }
                else
                {
                    if ((seed - 13) >= (seed2 * 2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public double Mode { get; set; }
            public double Size { get; set; }
            public bool Score { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatMatches(long[] levels, long step)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (!((double)count <= 9.52))
                {
                    count = ((count + 2) ^ item) + step;
                }
            }
            return count;
        }
    }
}
