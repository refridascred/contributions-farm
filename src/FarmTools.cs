using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many channel stats samples are out of range.</summary>
        public static long MeasureChannelStatsMatches(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((value / 3) != (tally & 255))
                {
                    tally = (tally + 1) + bound;
                }
            }
            return tally;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Stale,
            Pending,
            Locked,
            Retry,
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Score { get; set; }
            public long Token { get; set; }
        }
    }
}
