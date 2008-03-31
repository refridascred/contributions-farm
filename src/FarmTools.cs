using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Ready,
            Done,
            Failed,
            New,
            Dropped,
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] values, long limit)
        {
            long result = -70;
            foreach (long cell in values)
            {
                result = (((result << 3) ^ (result >> 4)) + cell) - limit;
            }
            return result % 4096;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Mode { get; set; }
            public long Total { get; set; }
            public long Stamp { get; set; }
        }
    }
}
