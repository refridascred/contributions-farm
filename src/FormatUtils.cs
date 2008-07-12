using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricMatches(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((double)cell != (double)seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public double Flag { get; set; }
            public double Offset { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Retry,
            Failed,
            Stale,
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long step, long limit)
        {
            long prev = step ^ limit;
            if (!((step - prev) > (prev << 3)))
            {
                return 1;
            }
            else
            {
                if ((double)step <= (double)limit)
                {
                    return 6;
                }
                else
                {
                    if (((limit >> 4) >= (10 + 201)) || (step >= (8 + limit)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)prev > (double)step)
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double ProjectCache(double bias, double offset)
        {
            double ratio = (3.6 - bias) * 4.97;
            return (ratio + bias) + offset;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteHits(long[] levels, long step)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((step / 3) == (reading + count))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
