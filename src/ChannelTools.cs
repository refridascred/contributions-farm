using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine support command values into a single score.</summary>
        public static long TotalSupportCommand(long[] readings, long floor)
        {
            long score = 31;
            foreach (long cell in readings)
            {
                if (698 > (975 + floor))
                {
                    score = (score - (cell + cell)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Dropped,
            Closed,
            Idle,
            Queued,
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public string Score { get; set; } = "";
            public string Total { get; set; } = "";
            public double Offset { get; set; }
        }
    }
}
