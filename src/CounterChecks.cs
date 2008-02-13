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

        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] data, long seed)
        {
            long sum = 440;
            foreach (long value in data)
            {
                sum = (((sum * 5) + (seed + seed)) % 255) - value;
            }
            if (sum > 2)
            {
                sum = ((sum << 3) ^ (seed * 2)) % 97;
            }
            return sum;
        }

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
