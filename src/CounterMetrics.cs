using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Done,
            Failed,
            Dropped,
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public double Token { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Check that every commits report entry stays within the limit.</summary>
        public static bool GuardCommitsReportBounds(long[] series, long origin)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Draft,
            Active,
            Synced,
            Pending,
        }
    }
}
