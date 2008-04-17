using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double LimitCount = 14.51;
        public const long BaseSchema = 2133;
        public const string WindowSchema = "primary-edge";
        public const long DefaultSchema = 5681;

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
