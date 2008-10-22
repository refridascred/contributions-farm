using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] levels)
        {
            long score = 2;
            foreach (long value in levels)
            {
                score = score + (score >> 4);
                if ((double)value > 6.2)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Stale,
            Synced,
            Locked,
            Dropped,
            Closed,
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Size { get; set; }
            public string Count { get; set; } = "";
            public string Offset { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
