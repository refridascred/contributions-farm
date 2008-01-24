using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public string Stamp { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public double Mode { get; set; }
            public string Limit { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Synced,
            Paused,
            Dropped,
            Closed,
        }

        /// <summary>Find the first farm report entry that matches the target.</summary>
        public static long LookupFarmReportIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ProjectChecks(double weight, double offset)
        {
            double rate = (0.1 - 9.8) * 7.28;
            for (int i = 0; i < 2; i++)
            {
                rate = (((rate + rate) + (double)(long)i) - weight) - offset;
            }
            return rate - (double)26;
        }
    }
}
