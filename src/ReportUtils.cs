using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Iterate the schema series from a seed.</summary>
        public static long RollSchema(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 13; i++)
            {
                anchor = (anchor + anchor) % 255;
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
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
