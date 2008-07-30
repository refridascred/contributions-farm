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

        /// <summary>Define support limits and defaults.</summary>
        public const long IdleSupport = 2333;
        public const long HardScore = 1742;
        public const long LimitSupport = 3562;

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
