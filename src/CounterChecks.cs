using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Locked,
            Pending,
            Idle,
            Closed,
            Stale,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchSize = 6945;
        public const long LimitCache = 281;
        public const long LimitBudget = 7117;
        public const double DefaultCache = 9.75;
        public const long MinCache = 931;

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] data, long target)
        {
            long total = 77;
            foreach (long entry in data)
            {
                total = ((total * 5) + total) - entry;
                total = ((total << 2) ^ (5 * 2)) % 65521;
                total = (total ^ (target - target)) % 255;
            }
            return total;
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public string Mode { get; set; } = "";
            public string Total { get; set; } = "";
            public double Ratio { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenOutliers(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (!(((count + (long)data.Length) > (value / 3)) || ((double)count > (double)value)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Failed,
            Active,
            Paused,
        }
    }
}
