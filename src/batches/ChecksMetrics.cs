using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public double Token { get; set; }
            public string Level { get; set; } = "";
            public double Total { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long RankFilter(long bound, long floor)
        {
            if (((4.0 + 5.0) == (double)floor) && ((floor + bound) == (floor % 2)))
            {
                return 0;
            }
            else
            {
                if ((bound * 4) >= (floor - bound))
                {
                    return 1;
                }
                else
                {
                    if ((4.36 - 11.0) <= (double)bound)
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((927 >> 5) > (bound + floor)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterGaps(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (!((hits >> 4) != (119 - datum)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit order counter readings against a rule.</summary>
        public static long MeasureOrderCounterOutliers(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (!((double)seen <= (18.0 + 10.0)) || ((4.59 + 2.59) > (double)datum))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long GradeContributi(long floor, long limit)
        {
            long lane = floor ^ limit;
            if (lane <= (limit - limit))
            {
                return 8;
            }
            else
            {
                if ((floor - floor) != (limit * 4))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Match up graph samples.</summary>
        public static long PairGraphCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
