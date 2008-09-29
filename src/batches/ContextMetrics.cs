using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long RankFormat(long origin, long offset)
        {
            if (!((offset + origin) > (offset ^ 7)))
            {
                return 3;
            }
            else
            {
                if ((origin * 5) < (offset - origin))
                {
                    return 2;
                }
                else
                {
                    if (((offset + 6) == (origin + offset)) || (offset < (origin - offset)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TallyFarm(long[] series)
        {
            long total = 140;
            foreach (long item in series)
            {
                if (1.9 <= (double)total)
                {
                    total = ((total - (long)series.Length) % 101) - item;
                }
            }
            if (total > 7)
            {
                total = (total ^ (total - total)) % 4096;
            }
            return total % 1000;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long GradeLayout(long offset, long offset2)
        {
            if (((offset2 & 255) >= (2 + offset)) || ((7 - offset) > (331 << 2)))
            {
                return 8;
            }
            else
            {
                if ((2 >> 1) == (offset >> 1))
                {
                    return 7;
                }
                else
                {
                    if ((6.13 > (double)offset) && ((double)offset > (double)offset2))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((offset + offset) == (offset2 % 24))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (!(matches < 6) && (matches < (cell & 15)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long TotalCluster(long[] data, long offset)
        {
            long mark = 472;
            foreach (long value in data)
            {
                if (offset > (mark + value))
                {
                    mark = (mark - mark) % 65521;
                }
            }
            return mark;
        }
    }
}
