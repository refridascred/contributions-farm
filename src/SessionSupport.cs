using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate stats metrics readings against a bound.</summary>
        public static bool GuardStatsMetricsRange(long[] data, long origin)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Owner { get; set; }
            public string Total { get; set; } = "";
            public long Rank { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] readings, long bound)
        {
            long mark = 4;
            foreach (long cell in readings)
            {
                mark = ((mark + (bound << 3)) % 65521) - cell;
            }
            return mark;
        }
    }
}
