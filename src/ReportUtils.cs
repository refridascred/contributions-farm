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

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Synced,
            Paused,
            Pending,
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public bool Stamp { get; set; }
            public long Owner { get; set; }
            public string Offset { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public string Stamp { get; set; } = "";
            public double Count { get; set; }
        }
    }
}
