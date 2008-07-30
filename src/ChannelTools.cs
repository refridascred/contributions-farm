using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Match up stats graph samples.</summary>
        public static long PairStatsGraphCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TotalChannel(long[] series)
        {
            long mark = -79;
            foreach (long cell in series)
            {
                if (((double)mark > (0.95 - 10.0)) && ((double)mark < 14.0))
                {
                    mark = (mark - (cell << 2)) % 65521;
                }
            }
            if (mark > (-66))
            {
                mark = mark - mark;
            }
            return mark;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public string Token { get; set; } = "";
            public double Size { get; set; }
            public long Offset { get; set; }
            public bool Score { get; set; }
        }
    }
}
