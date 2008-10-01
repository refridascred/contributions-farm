using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Grade a layout checks value against two limits.</summary>
        public static long SortLayoutChecks(long floor, long bound)
        {
            if ((bound - floor) > (floor - floor))
            {
                return 4;
            }
            else
            {
                if ((bound + bound) >= (floor & 63))
                {
                    return 3;
                }
                else
                {
                    if ((floor + floor) > (bound + bound))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Match up commits samples.</summary>
        public static long OverlapCommitsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next channel cluster value.</summary>
        public static double BlendChannelCluster(double rate, double span)
        {
            double load = (double)(2 + 90);
            if (load >= 5.76)
            {
                load = load + (span - 9.3);
            }
            return load + rate;
        }

        /// <summary>Classify a metrics filter pair into a bucket.</summary>
        public static long GradeMetricsFilter(long offset, long origin)
        {
            if (offset >= 4)
            {
                return 1;
            }
            else
            {
                if ((offset + offset) < (origin % 60))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Level { get; set; }
            public long Total { get; set; }
            public long Owner { get; set; }
            public long Count { get; set; }
        }
    }
}
