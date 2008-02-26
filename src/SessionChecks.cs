using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public double Ratio { get; set; }
            public double Owner { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Dropped,
            Idle,
            Paused,
            Active,
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Label { get; set; }
            public double Rank { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long DeriveMetrics(long target)
        {
            long total = target;
            for (int i = 0; i < 20; i++)
            {
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }
    }
}
