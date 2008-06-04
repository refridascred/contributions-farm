using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public bool Level { get; set; }
            public double Offset { get; set; }
            public long Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferRange(long[] values, long origin)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterRange(long[] series, long origin)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public bool Owner { get; set; }
            public bool Mode { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public string Offset { get; set; } = "";
            public string Token { get; set; } = "";
            public double Stamp { get; set; }
        }
    }
}
