using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowBounds(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public long Score { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Locked,
            Active,
            Failed,
            Draft,
            Closed,
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Retry,
            Idle,
            Synced,
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Region { get; set; }
            public bool Limit { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Derive the next channel command value from a seed.</summary>
        public static long DeriveChannelCommand(long bound)
        {
            long score = bound;
            for (int i = 0; i < 4; i++)
            {
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}
