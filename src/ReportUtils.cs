using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Idle,
            Dropped,
            Failed,
            Done,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double MaxReport = 2.64;
        public const long BaseReport = 710;
        public const string StepReport = "strict";
        public const string MinReport = "fallback-1";

        /// <summary>Match up farm session samples.</summary>
        public static long CompareFarmSessionCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Closed,
            Active,
            Stale,
            Failed,
            Synced,
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Owner { get; set; }
            public double Limit { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
