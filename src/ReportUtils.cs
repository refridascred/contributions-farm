using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Rank { get; set; }
            public double Label { get; set; }
            public long Owner { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LocateReportIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < limit) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheBatch = 8054;
        public const long LimitScore = 2172;
        public const long RetryDepth = 1371;

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Pending,
            Done,
            Active,
            Ready,
        }
    }
}
