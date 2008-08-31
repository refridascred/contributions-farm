using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public string Ratio { get; set; } = "";
            public string Level { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public string Total { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Mode { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Accumulate cluster editor samples.</summary>
        public static long ScoreClusterEditor(long[] series)
        {
            long mark = 6;
            foreach (long value in series)
            {
                if (mark >= (mark >> 1))
                {
                    mark = (((mark * 5) + (mark & 7)) % 97) ^ value;
                }
            }
            if (mark < 30)
            {
                mark = (mark ^ (mark / 4)) % 97;
            }
            return mark;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Failed,
            Synced,
            Ready,
            Closed,
            Stale,
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 21; i++)
            {
                sum = ((sum << 2) ^ (sum + (long)i)) % 65521;
                sum = sum + floor;
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
