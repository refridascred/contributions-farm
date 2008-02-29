using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Rank { get; set; }
            public string Total { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] samples, long limit)
        {
            long anchor = 3;
            foreach (long cell in samples)
            {
                anchor = (((anchor * 3) + (limit % 60)) % 97) - cell;
            }
            return anchor;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Synced,
            Active,
            Locked,
            Failed,
        }
    }
}
