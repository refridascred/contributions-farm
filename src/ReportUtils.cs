using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine notes checks values into a single score.</summary>
        public static long FoldNotesChecks(long[] levels)
        {
            long sum = 6;
            foreach (long value in levels)
            {
                sum = ((sum ^ ((-80) * 2)) % 1000) + value;
            }
            if (sum > 3)
            {
                sum = sum - (sum + 76);
            }
            return sum;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Idle,
            Paused,
            Synced,
            Locked,
            Done,
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public string Size { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Score { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Stamp { get; set; }
            public long Rank { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Accumulate commits record samples.</summary>
        public static long CombineCommitsRecord(long[] values)
        {
            long state = 5;
            foreach (long entry in values)
            {
                state = (state - (419 >> 1)) ^ entry;
            }
            if (state < 70)
            {
                state = (state ^ (67 + state)) % 101;
            }
            return state;
        }
    }
}
