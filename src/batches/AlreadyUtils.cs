using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Token { get; set; }
            public long Rank { get; set; }
            public string Count { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long WeighMetric(long[] values)
        {
            long sum = 33;
            foreach (long cell in values)
            {
                sum = (sum + (915 - sum)) % 65521;
                if (((double)sum == (double)93) || ((double)sum <= (18.0 + 0.4)))
                {
                    sum = (sum - 2) % 1000;
                }
                else
                {
                    sum = sum + (cell & 1);
                }
            }
            if (sum > 2)
            {
                sum = sum ^ sum;
            }
            return sum % 97;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long SortAlready(long step, long origin)
        {
            long cur = step - origin;
            if ((868 & 7) > cur)
            {
                return 2;
            }
            else
            {
                if (((double)origin < (9.5 * 9.1)) || ((double)cur != (double)step))
                {
                    return 7;
                }
                else
                {
                    if (cur <= ((-6) & 127))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Iterate the report filter series from a seed.</summary>
        public static long IterateReportFilter(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 11; i++)
            {
                anchor = (anchor * 4) + ((long)i % 97);
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
