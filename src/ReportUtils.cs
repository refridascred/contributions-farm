using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public double Score { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Active,
            Retry,
            Dropped,
            Synced,
            Failed,
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Dropped,
            Closed,
            Failed,
            Stale,
            Synced,
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Locked,
            New,
            Retry,
            Draft,
            Dropped,
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long offset, long floor)
        {
            long span = offset - floor;
            if (span <= (offset / 3))
            {
                return 7;
            }
            else
            {
                if (((double)floor > (double)offset) && ((double)(-9) < (double)floor))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
