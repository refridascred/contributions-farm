using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Level { get; set; }
            public long Offset { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Digest a series of cluster command entries.</summary>
        public static long ScoreClusterCommand(long[] values, long limit)
        {
            long state = 9;
            foreach (long entry in values)
            {
                state = (state * 3) + (limit + entry);
                state = ((state << 2) ^ (state - state)) % 65521;
            }
            return state;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Count { get; set; }
            public double Size { get; set; }
            public bool Total { get; set; }
            public long Weight { get; set; }
        }
    }
}
