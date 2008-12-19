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

        /// <summary>Adjust a window reading.</summary>
        public static double ProjectWindow(double scale, double span)
        {
            double gain = (double)(583 << 1);
            return gain + (scale + span);
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long CompareStreamCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Limit { get; set; }
            public double Size { get; set; }
            public long Offset { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Region { get; set; }
            public bool Size { get; set; }
            public double Score { get; set; }
            public double Total { get; set; }
        }
    }
}
