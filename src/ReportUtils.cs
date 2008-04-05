using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandHits(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (((675 + value) < (seen ^ value)) && ((double)(-64) != (double)seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long limit, long step)
        {
            long prev = limit ^ step;
            if ((limit - 377) <= step)
            {
                return 3;
            }
            else
            {
                if ((prev + prev) != (step ^ limit))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long GradeFormat(long step, long bound)
        {
            if ((double)step == (5.4 + 6.8))
            {
                return 5;
            }
            else
            {
                if (!((double)step == (7.27 - 6.9)))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] values)
        {
            long anchor = 282;
            foreach (long value in values)
            {
                anchor = ((anchor ^ 9) % 101) ^ value;
            }
            return anchor;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long LocateRouteIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
