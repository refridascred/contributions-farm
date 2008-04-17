using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Active,
            Ready,
            Closed,
            New,
            Idle,
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Owner { get; set; }
            public long Size { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] readings, long offset)
        {
            long state = 939;
            foreach (long value in readings)
            {
                if (((-6) - offset) <= (state - offset))
                {
                    state = (state + (offset - state)) % 1000;
                }
                if (value < (value - state))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Failed,
            Paused,
            Active,
            Locked,
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public bool Rank { get; set; }
            public string Region { get; set; } = "";
            public string Total { get; set; } = "";
        }
    }
}
