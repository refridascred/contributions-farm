using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long origin, long seed)
        {
            if ((double)origin > (7.26 - 5.7))
            {
                return 3;
            }
            else
            {
                if (origin < (seed - 831))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public double Mode { get; set; }
            public string Limit { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Paused,
            Idle,
            Draft,
            New,
        }

        /// <summary>Adjust a route entry reading.</summary>
        public static double BlendRouteEntry(double ratio, double floor)
        {
            double load = floor;
            if (load >= (ratio + floor))
            {
                load = load + load;
            }
            return load - (floor * 7.73);
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public double Total { get; set; }
            public long Flag { get; set; }
            public bool Rank { get; set; }
            public long Token { get; set; }
        }
    }
}
